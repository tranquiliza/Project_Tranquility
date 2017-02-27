using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Tranquility.Core.DomainModels;
using Project_Tranquility.Core.Services;
using Project_Tranquility.Web.Models;

namespace Project_Tranquility.Web.Controllers
{
    public class ProjectManagerController : Controller
    {
        private readonly IService<MaintainanceTask> _Service;
        public ProjectManagerController(IService<MaintainanceTask> service)
        {
            _Service = service;
        }

        // GET: ProjectManager
        public ActionResult Index()
        {

            var model = new TaskViewModel
            {
                Tasks = _Service.GetAll()
            };

            return View(model);
        }
    }
}