using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class Product : BaseEntity
    {
        public virtual string Name { get; private set; }
        public virtual string Description { get; private set; }
        public virtual string ProductNumber { get; private set; }
        public virtual string Model { get; private set; }
        public virtual int NumberInStock { get; private set; }
        public virtual string LocationInWareHouse { get; private set; }
        public virtual decimal PurchasePrice { get; private set; }
        public virtual decimal SellPrice { get; private set; }
        public virtual decimal VAT { get; private set; }
        public virtual decimal Weight { get; private set; }
        public virtual ICollection<Color> Colors { get; private set; }
        public virtual ICollection<Material> Materials { get; private set; }
    }
}
