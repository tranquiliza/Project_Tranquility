using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Tranquility.Core.DomainModels;
using Project_Tranquility.Core.Services;
using Project_Tranquility.Web.Models.ProjectManagerViewModels;
using System.Security.Claims;
using Project_Tranquility.Web.Extensions;

namespace Project_Tranquility.Web.Controllers
{
    [Authorize]
    public class ProjectManagerController : BaseController
    {
        private readonly IService<MaintainanceTask> _Service;
        private readonly int _PageSize;

        public ProjectManagerController(IService<MaintainanceTask> service)
        {
            _Service = service;
            _PageSize = 15;
        }
        
        public ActionResult Index(int pageIndex = 1)
        {
            ViewBag.pageIndex = pageIndex;

            //IF user is the Developer
            if (User.IsInRole("Developer"))
            {
                var modelWithAll = new IndexViewModel()
                {
                    Tasks = _Service.GetAll(pageIndex, _PageSize, m => (int)m.Status)
                };
                return View(modelWithAll);
            }

            //If user is a departmentLeader
            if (User.IsInRole("Department Leader"))
            {
                var departmentId = User.Identity.GetDepartmentId();
                var departmentModel = new IndexViewModel()
                {
                    Tasks = _Service.GetAll(pageIndex, _PageSize, m => (int)m.Status, m => m.Department.Id == departmentId, Core.Data.OrderBy.Ascending, m => m.Staff, m => m.Department)
                };
                return View(departmentModel);
            }

            //If user is employee
            if (User.IsInRole("Employee"))
            {
                var staffId = User.Identity.GetStaffId();
                var staffModel = new IndexViewModel()
                {
                    Tasks = _Service.GetAll(pageIndex, _PageSize, m => (int)m.Status, m => m.Staff.Id == staffId, Core.Data.OrderBy.Ascending, m => m.Staff, m => m.Department)
                };
                return View(staffModel);
            }

            //If user is not attached anything.
            var userId = User.Identity.GetUserId();
            var model = new IndexViewModel()
            {
                Tasks = _Service.GetAll(pageIndex, _PageSize, m => (int)m.Status, m => m.UserId == userId, Core.Data.OrderBy.Ascending, m => m.Staff, m => m.Department)
            };
            return View(model);
        }
    }
}