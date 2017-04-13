using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class InquiryProductLine : BaseEntity
    {
        public virtual int Amount { get; set; }
        public virtual Product Product { get; set; }
    }
}
