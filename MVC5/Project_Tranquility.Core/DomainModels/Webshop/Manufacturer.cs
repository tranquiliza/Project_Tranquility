using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    //Perhabs should be named Supplier?
    public class Manufacturer : BaseEntity
    {
        public virtual string Name { get; private set; }

        protected Manufacturer() { }

        public Manufacturer(string name)
        {
            Name = name;
        }
    }
}
