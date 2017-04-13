using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class Customer : BaseEntity
    {
        public virtual string FirstName { get; set; }
        public virtual string SurName { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual int ZIP { get; set; }
        public virtual string StreetName { get; set; }
        public virtual int StreetNumber { get; set; }
        public virtual string Country { get; set; }
    }
}
