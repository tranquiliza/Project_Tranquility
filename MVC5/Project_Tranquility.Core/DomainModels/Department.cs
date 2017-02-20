using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels
{
    public class Department : BaseEntity
    {
        public virtual string Name { get; set; }
    }
}
