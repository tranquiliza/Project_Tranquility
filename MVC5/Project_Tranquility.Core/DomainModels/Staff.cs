using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels
{
    public class Staff : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual Department Department { get; set; }
    }
}
