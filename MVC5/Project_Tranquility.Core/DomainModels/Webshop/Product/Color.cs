using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class Color : BaseEntity
    {
        public virtual string Name { get; private set; }
        public virtual decimal Percentage { get; private set; }

        protected Color() { }

        public Color(string name, decimal percentage)
        {
            Name = name;
            Percentage = percentage;
        }

        public void ChangePercentage(decimal newPercentage)
        {
            Percentage = newPercentage;
        }
    }
}
