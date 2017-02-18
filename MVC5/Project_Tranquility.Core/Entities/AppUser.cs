using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.Entities
{
    public class AppUser : ClaimsPrincipal
    {
        public AppUser(ClaimsPrincipal principal) : base (principal)
        {
        }

        public string Name
        {
            get
            {
                return this.FindFirst(ClaimTypes.Name).Value;
            }
        }

        public string Country
        {
            get
            {
                return this.FindFirst(ClaimTypes.Country).Value;
            }
        }
    }
}
