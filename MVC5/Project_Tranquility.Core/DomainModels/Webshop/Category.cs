using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class Category : BaseEntity
    {
        public virtual string Name { get; private set; }
        public virtual ICollection<Subcategory> Subcategories { get; set; }

        protected Category() { }

        public Category(string name)
        {
            Name = name;
            Subcategories = new HashSet<Subcategory>();
        }

        public void AddSubcategory(Subcategory subcategory)
        {
            if (subcategory != null)
            {
                Subcategories.Add(subcategory);
            }
        }
        
        public void AddSubcategory(string name)
        {
            var subcategory = new Subcategory(name);
            Subcategories.Add(subcategory);
        }
    }
}
