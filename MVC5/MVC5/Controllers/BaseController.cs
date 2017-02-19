//using Project_Tranquility.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace MVC5.Controllers
{
    public class BaseController : Controller
    {
        //public AppUserPrincipal CurrentUser
        //{
        //    get
        //    {
        //        return new AppUserPrincipal(this.User as ClaimsPrincipal);
        //    }
        //}
        public BaseController()
        {
        }
    }
}