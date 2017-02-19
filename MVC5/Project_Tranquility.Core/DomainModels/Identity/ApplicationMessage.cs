using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Identity
{
    public class ApplicationMessage
    {
        public virtual string Body { get; set; }
        public virtual string Destination { get; set; }
        public virtual string Subject { get; set; }
    }
}
