using Project_Tranquility.Core.DomainModels.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Tranquility.Web.Models.AccountViewModels
{
    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
        public IEnumerable<ApplicationAuthenticationDescription> LoginProviders { get; set; }
    }
}