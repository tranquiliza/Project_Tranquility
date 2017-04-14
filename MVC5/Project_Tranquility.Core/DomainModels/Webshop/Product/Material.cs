using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class Material : BaseEntity
    {
        public virtual string Name { get; private set; }
        public virtual decimal Percentage { get; private set; }

        protected Material() { }

        public Material(string name, decimal percentage)
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
