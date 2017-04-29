using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class Supplier : BaseEntity
    {
        public virtual string CompanyName { get; private set; }
        public virtual string PhoneNumber { get; private set; }
        public virtual string Email { get; private set; }
        public virtual string CVRNumber { get; private set; }
        public virtual string ContactPerson { get; private set; }

        protected Supplier() { }

        public Supplier(string companyName, string phoneNumber, string email, string cvrNumber, string contactPerson)
        {
            CompanyName = companyName;
            PhoneNumber = phoneNumber;
            Email = email;
            CVRNumber = cvrNumber;
            ContactPerson = contactPerson;
        }
    }
}
