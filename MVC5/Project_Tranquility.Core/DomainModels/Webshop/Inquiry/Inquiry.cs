using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels.Webshop
{
    public class Inquiry : BaseEntity
    {
        public virtual ICollection<InquiryProductLine> InquiryLines { get; set; }
        public virtual DateTimeOffset PurchaseDate { get; set; }
        public virtual Customer Customer { get; set; }

        protected Inquiry() { }

        public Inquiry(Customer customer)
        {
            PurchaseDate = DateTimeOffset.Now;
            InquiryLines = new List<InquiryProductLine>();
            Customer = customer;
        }

        public void AddInquiryLine(Product product, int amount)
        {
            var inquiryLine = new InquiryProductLine(product, amount);
            InquiryLines.Add(inquiryLine);
        }
        
        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var line in InquiryLines)
            {
                total += (line.Product.GetSellPrice() * line.Amount);
            }
            return total;
        }
    }
}
