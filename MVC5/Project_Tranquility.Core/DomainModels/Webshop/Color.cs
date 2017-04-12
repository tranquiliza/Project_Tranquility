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
    }
}
