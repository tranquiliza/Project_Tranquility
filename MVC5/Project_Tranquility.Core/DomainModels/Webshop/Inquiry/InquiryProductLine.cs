using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class InquiryProductLine : BaseEntity
    {
        public virtual Product Product { get; private set; }
        public virtual int Amount { get; private set; }

        protected InquiryProductLine() { }

        public InquiryProductLine(Product product, int amount)
        {
            Product = product;
            Amount = amount;
        }

        public void IncrementAmount()
        {
            Amount++;
        }

        public void DecrementAmount()
        {
            Amount--;
        }
    }
}
