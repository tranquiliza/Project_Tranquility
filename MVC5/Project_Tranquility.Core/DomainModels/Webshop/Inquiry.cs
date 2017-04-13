using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class Inquiry : BaseEntity
    {
        public virtual ICollection<Product> Products { get; set; }
        public virtual DateTimeOffset PurchaseDate { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
