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
        public virtual int ZIPCode { get; set; }
        public virtual string StreetName { get; set; }
        public virtual int StreetNumber { get; set; }
        public virtual string Country { get; set; }

        protected Customer() { }
        
        public Customer(string firstName, string surName)
        {
            FirstName = firstName;
            SurName = surName;
        }

        public void SetPhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public void SetAdress(string country, int zipCode, string streetName, int streetNumber)
        {
            Country = country;
            ZIPCode = zipCode;
            StreetName = streetName;
            StreetNumber = streetNumber;
        }
    }
}
