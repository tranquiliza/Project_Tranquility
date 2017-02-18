using MVC5.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    [AllowAnonymous]
    public class AuthController : BaseController
    {
        public ActionResult Login(string returnUrl)
        {
            var model = new LoginModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (model.Email == "admin@tranq.com" && model.Password == "admin")
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, "Daniel"),
                    new Claim(ClaimTypes.Email, "admin@tranq.com"),
                    new Claim(ClaimTypes.Country, "Denmark")
                }, 
                "ApplicationCookie");

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;

                authManager.SignIn(identity);
                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }

            ModelState.AddModelError(string.Empty, "Invalid email or password");
            return View();
        }

        public ActionResult Logout()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }

        private string GetRedirectUrl(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("Index", "Home");
            }
            return returnUrl;
        }
    }
}