using Project_Tranquility.Core.DomainModels.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Tranquility.Web.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<ApplicationUserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
    }
}