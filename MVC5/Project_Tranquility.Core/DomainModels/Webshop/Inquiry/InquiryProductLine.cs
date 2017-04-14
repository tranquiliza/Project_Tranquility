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
            if (IsValidInput(product, amount))
            {
                Product = product;
                Amount = amount;
            }
            throw new ArgumentException("Invalid product or amount given!");
        }

        private bool IsValidInput(Product product, int amount)
        {
            if (product != null && amount != 0)
            {
                return true;
            }
            return false;
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
