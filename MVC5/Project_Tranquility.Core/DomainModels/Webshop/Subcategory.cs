using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class Subcategory : BaseEntity
    {
        public ICollection<Product> Products { get; set; }
    }
}
