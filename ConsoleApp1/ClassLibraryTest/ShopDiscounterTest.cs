using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using Moq;

namespace ClassLibraryTest
{
    [TestFixture]
    internal class ShopDiscounterTest
    {
        [Test]
        public void AddDiscountToItem_Should_Throw_Exception_When_DiscountPercent_Is_Less_Than_Zero()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            var shopDiscounter = new ShopDiscounter(mockLogger.Object);
            var item = new Mock<IItem>().Object;
            int discountPercent = -10;

            // Act & Assert
            Assert.Throws<Exception>(() => shopDiscounter.AddDiscountToItem(item, discountPercent));
            mockLogger.Verify(logger => logger.Warn(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void AddDiscountToItem_Should_Throw_Exception_When_DiscountPercent_Is_Greater_Than_100()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            var shopDiscounter = new ShopDiscounter(mockLogger.Object);
            var item = new Mock<IItem>().Object;
            int discountPercent = 110;

            // Act & Assert
            Assert.Throws<Exception>(() => shopDiscounter.AddDiscountToItem(item, discountPercent));
            mockLogger.Verify(logger => logger.Warn(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void AddDiscountToItem_Should_Decrease_Price_With_Given_DiscountPercent()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            var shopDiscounter = new ShopDiscounter(mockLogger.Object);
            var item = new Mock<IItem>();
            item.SetupProperty(i => i.Price, 100.0m);
            int discountPercent = 20;

            // Act
            var discountedItem = shopDiscounter.AddDiscountToItem(item.Object, discountPercent);

            // Assert
            Assert.AreEqual(80.0m, discountedItem.Price);
        }
    }
}
