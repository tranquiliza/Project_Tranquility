﻿using Project_Tranquility.Core.DomainExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class Product : BaseEntity
    {
        public virtual string ProductNumber { get; private set; }
        public virtual string Name { get; private set; }
        public virtual string Description { get; private set; }
        public virtual string Model { get; private set; }

        public virtual int NumberInStock { get; private set; }
        public virtual string LocationInWareHouse { get; private set; }

        public virtual decimal PurchasePrice { get; private set; }
        public virtual decimal ContributionRatio { get; private set; }

        public virtual string Image { get; private set; }
        public virtual ICollection<Color> Colors { get; private set; }
        public virtual ICollection<Material> Materials { get; private set; }
        public virtual Dimensions Dimensions { get; private set; }
        public virtual float Weight { get; private set; }

        public virtual Supplier Supplier { get; private set; }

        public virtual Subcategory SubCategory { get; private set; }

        private Product() { }

        public Product(string name, string description, string productNumber, decimal purchasePrice)
        {
            Name = name;
            Description = description;
            ProductNumber = productNumber;
            PurchasePrice = purchasePrice;
            Colors = new List<Color>();
            Materials = new List<Material>();
        }

        public void AddColor(string colorName, float percentage)
        {
            var colorToAdd = new Color(colorName, percentage);
            AddColor(colorToAdd);
        }

        private void AddColor(Color color)
        {
            if (AddingTooMuchColor(color.Percentage)) throw new BasicDomainException();
            Colors.Add(color);
        }

        private bool AddingTooMuchColor(float percent)
        {
            return GetCurrentColorPercent() + percent > 100;
        }

        private float GetCurrentColorPercent()
        {
            float total = 0;
            foreach (Color color in Colors)
            {
                total += color.Percentage;
            }
            return total;
        }

        public void AddMaterial(string materialName, float percentage)
        {
            var materialToAdd = new Material(materialName, percentage);
            AddMaterial(materialToAdd);
        }

        private void AddMaterial(Material material)
        {
            Materials.Add(material);
        }

        public decimal GetSellPrice()
        {
            var price = PurchasePrice * ContributionRatio * Constants.VAT;
            return price;
        }
    }
}
