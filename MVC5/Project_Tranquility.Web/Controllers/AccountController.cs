using Project_Tranquility.Core.Identity;
using Project_Tranquility.Core.DomainModels.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Tranquility.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private IApplicationUserManager _userManager;


        public AccountController(IApplicationUserManager userManager)
        {
            _userManager = userManager;
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.LoginProviders = _userManager.GetExternalAuthenticationTypes();
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //// GET: Account
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}