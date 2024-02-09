using Moq;
using ClassLibrary.Interfaces;
using ClassLibrary;

namespace ClassLibraryTest
{
    [TestFixture]
    internal class ShopTest
    {
        [Test]
        public void BuyItem_Should_Return_Item_When_It_Exists_In_Database()
        {
            // Arrange
            var itemName = "TestItem";
            var expectedItem = new Mock<IItem>().Object;

            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.GetItem(itemName)).Returns(expectedItem);

            var mockLogger = new Mock<ILogger>();

            var shop = new Shop(new Mock<IShopDiscounter>().Object, mockLogger.Object, expectedItem, mockDb.Object);

            // Act
            var result = shop.BuyItem(itemName);

            // Assert
            Assert.AreEqual(expectedItem, result);
            mockLogger.Verify(logger => logger.Warn(It.IsAny<string>()), Times.Never);
        }

        [Test]
        public void BuyItem_Should_Log_Warning_When_Item_Does_Not_Exist_In_Database()
        {
            // Arrange
            var itemName = "NonExistentItem";
            var expectedErrorMessage = $"Item with name {itemName} is missed";

            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.GetItem(itemName)).Returns((IItem)null);

            var mockLogger = new Mock<ILogger>();

            var shop = new Shop(new Mock<IShopDiscounter>().Object, mockLogger.Object, null, mockDb.Object);

            // Act & Assert
            Assert.Throws<ClassLibrary.Exceptions.ShopItemMissedException>(() => shop.BuyItem(itemName));
            mockLogger.Verify(logger => logger.Warn(expectedErrorMessage), Times.Once);
        }

        [Test]
        public void BuyItemWithDiscount_Should_Return_Discounted_Item_When_It_Exists_In_Database()
        {
            // Arrange
            var itemName = "TestItem";
            var expectedItem = new Mock<IItem>().Object;

            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.GetItem(itemName)).Returns(expectedItem);

            var mockLogger = new Mock<ILogger>();

            var mockDiscounter = new Mock<IShopDiscounter>();
            mockDiscounter.Setup(discounter => discounter.AddDiscountToItem(expectedItem, It.IsAny<int>())).Returns(expectedItem);

            var shop = new Shop(mockDiscounter.Object, mockLogger.Object, expectedItem, mockDb.Object);

            // Act
            var result = shop.BuyItemWithDiscount(itemName, 10);

            // Assert
            Assert.AreEqual(expectedItem, result);
        }
    }
}
