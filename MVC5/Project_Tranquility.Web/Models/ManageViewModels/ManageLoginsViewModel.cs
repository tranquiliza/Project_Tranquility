using Project_Tranquility.Core.DomainModels.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Tranquility.Web.Models.ManageViewModels
{
    public class ManageLoginsViewModel
    {
        public IList<ApplicationUserLoginInfo> CurrentLogins { get; set; }
        public IList<ApplicationAuthenticationDescription> OtherLogins { get; set; }
    }
}