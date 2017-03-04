using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Tranquility.Core.DomainModels;
using Project_Tranquility.Core.Services;
using Project_Tranquility.Web.Models;
using System.Security.Claims;
using Project_Tranquility.Web.Extensions;

namespace Project_Tranquility.Web.Controllers
{
    public class ProjectManagerController : BaseController
    {
        private readonly IService<MaintainanceTask> _Service;
        public ProjectManagerController(IService<MaintainanceTask> service)
        {
            _Service = service;
        }

        // GET: ProjectManager
        public ActionResult Index()
        {
            if (User.IsInRole("Department Leader"))
            {
                var departmentId = User.Identity.GetDepartmentId();
                var departmentModel = new TaskViewModel
                {
                    Tasks = _Service.GetAll(1, 25, m => m.Id, m => m.Department.Id == departmentId, Core.Data.OrderBy.Ascending, m => m.Staff, m => m.Department)
                };
                return View(departmentModel);
            }
                

            var userStaffId = User.Identity.GetStaffId();
            var model = new TaskViewModel
            {
                Tasks = _Service.GetAll(1, 25, m => m.Id, m => m.Staff.Id == userStaffId, Core.Data.OrderBy.Ascending, includeProperties: m => m.Staff)
            };

            return View(model);
        }
    }
}