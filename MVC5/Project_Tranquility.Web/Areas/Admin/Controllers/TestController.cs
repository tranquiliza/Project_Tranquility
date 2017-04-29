using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Tranquility.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Developer, Admin")]
    public class TestController : Controller
    {
        // GET: Admin/Test
        public ActionResult Index()
        {
            return View();
        }
    }
}