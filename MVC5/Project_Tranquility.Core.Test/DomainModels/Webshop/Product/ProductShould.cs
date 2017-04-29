using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Tranquility.Core.DomainModels.Webshop;
using Project_Tranquility.Core.DomainExceptions;

namespace Project_Tranquility.Core.Test.DomainModels.Webshop
{
    [TestFixture]
    public class ProductShould
    {
        [Test]
        public void Throw_If_Colors_Exceed_100_Percent()
        {
            //Arrange
            void addTooMuchColer()
            {
                var product = CreateProductWith90PercentColors();
                var colorName = "TwentyPercent";
                var percent = 20;
                product.AddColor(colorName, percent);
            }

            //Act
            var delegateUnderTest = new TestDelegate(addTooMuchColer);
            
            //Assert
            Assert.Throws<BasicDomainException>(delegateUnderTest);
        }

        private Product CreateProductWith90PercentColors()
        {
            var product = new Product("Test", "Description", "ProductNumberTwo", 100);
            product.AddColor("90PercentColor", 90);
            return product;
        }

        [Test]
        public void Add_New_Color_To_Collection()
        {
            //Arrange
            var product = CreateProduct();
            var color = "TestColor";
            var percentage = 10;

            //Act
            product.AddColor(color, percentage);

            //Assert
            var colorFromCollection = product.Colors.First(m => m.Name == color);
            Assert.AreEqual(color, colorFromCollection.Name);
            Assert.AreEqual(percentage, colorFromCollection.Percentage);
        }

        private Product CreateProduct()
        {
            return new Product("TestProduct", "This product exists only to test", "ProductNumberOne", 100);
        }
    }
}
