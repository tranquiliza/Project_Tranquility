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
        public virtual float Percentage { get; private set; }

        protected Material() { }

        public Material(string name, float percentage)
        {
            Name = name;
            Percentage = percentage;
        }

        public void ChangePercentage(float newPercentage)
        {
            Percentage = newPercentage;
        }
    }
}
