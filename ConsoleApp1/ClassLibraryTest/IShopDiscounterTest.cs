using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    [TestFixture]
    internal class IShopDiscounterTest
    {
        [Test]
        public void AddDiscountToItem_Should_Return_Discounted_Item_With_Correct_Price()
        {
            // Arrange
            var mockItem = new Mock<IItem>();
            mockItem.SetupProperty(i => i.Price, 100.0m);
            var item = mockItem.Object;

            var shopDiscounter = new ShopDiscounter(new Mock<ILogger>().Object);
            int discountPercent = 20;

            // Act
            var discountedItem = shopDiscounter.AddDiscountToItem(item, discountPercent);

            // Assert
            Assert.AreEqual(80.0m, discountedItem.Price);
        }
    }
}
