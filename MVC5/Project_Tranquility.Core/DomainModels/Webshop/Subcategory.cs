using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class Subcategory : BaseEntity
    {
        public virtual string Name { get; private set; }
        public virtual ICollection<Product> Products { get; set; }

        protected Subcategory() { }

        public Subcategory(string name)
        {
            Name = name;
            Products = new HashSet<Product>();
        }

        public void AddProduct(Product product)
        {
            if (product != null)
            {
                if (!Products.Contains(product))
                {
                    Products.Add(product);
                }
                else
                {
                    throw new Exception("Product is already registered in this category!");
                }
            }
        }
    }
}
