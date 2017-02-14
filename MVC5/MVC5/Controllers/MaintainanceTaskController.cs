using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Tranquility.Core.Services;
using Ninject;

namespace MVC5.Controllers
{
    public class MaintainanceTaskController : BaseController
    {
        private ITaskService _TaskService;

        public MaintainanceTaskController(ITaskService service)
        {
            _TaskService = service;
        }

        // GET: MaintainanceTask
        public ActionResult Index()
        {
            var items = _TaskService.GetAll();

            return View(items);
        }
    }
}