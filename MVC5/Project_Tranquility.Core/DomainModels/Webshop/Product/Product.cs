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
        public virtual string Image { get; private set; }
        public virtual ICollection<Color> Colors { get; private set; }
        public virtual ICollection<Material> Materials { get; private set; }
        public virtual Manufacturer Manufacturer { get; private set; }

        protected Product() { }

        public Product(string name, string description, string productNumber, decimal purchasePrice)
        {
            Name = name;
            Description = description;
            ProductNumber = productNumber;
            PurchasePrice = purchasePrice;
            Colors = new List<Color>();
            Materials = new List<Material>();
        }

        public void AddColor(string colorName, decimal percentage)
        {
            var colorToAdd = new Color(colorName, percentage);
            Colors.Add(colorToAdd);
        }

        public void AddColor(Color color)
        {
            Colors.Add(color);
        }

        public void AddMaterial(string materialName, decimal percentage)
        {
            var materialToAdd = new Material(materialName, percentage);
            Materials.Add(materialToAdd);
        }

        public void AddMaterial(Material material)
        {
            Materials.Add(material);
        }
    }
}
