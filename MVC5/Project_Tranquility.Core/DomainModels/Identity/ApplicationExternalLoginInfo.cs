using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Project_Tranquility.Core.DomainModels.Identity
{
    public class ApplicationExternalLoginInfo
    {
        public string DefaultUserName { get; set; }
        public string Email { get; set; }
        public ClaimsIdentity ExternalIdentity { get; set; }
        public ApplicationUserLoginInfo Login { get; set; }
    }
}
