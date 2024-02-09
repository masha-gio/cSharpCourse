using ClassLibrary.Classes;

namespace ClassLibraryTest
{
    [TestFixture]
    internal class ShopItemTest
    {
        public void Constructor_Should_Throw_Exception_When_Name_Is_Null()
        {
            // Arrange
            string name = null;
            decimal price = 10.0m;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new ShopItem(name, price));
        }

        [Test]
        public void Constructor_Should_Throw_Exception_When_Price_Is_Null()
        {
            // Arrange
            string name = "Test Item";
            decimal? price = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new ShopItem(name, price));
        }

        [Test]
        public void Constructor_Should_Create_Instance_With_Given_Name_And_Price()
        {
            // Arrange
            string expectedName = "Test Item";
            decimal expectedPrice = 10.0m;

            // Act
            var item = new ShopItem(expectedName, expectedPrice);

            // Assert
            Assert.AreEqual(expectedName, item.Name);
            Assert.AreEqual(expectedPrice, item.Price);
        }
    }
}