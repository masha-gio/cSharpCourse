using ClassLibrary.Interfaces;
using Moq;

namespace ClassLibraryTest
{
    [TestFixture]
    internal class IDbTest
    {
        [Test]
        public void GetItem_Should_Return_Item_When_It_Exists_In_Database()
        {
            // Arrange
            var itemName = "TestItem";
            var expectedItem = new Mock<IItem>().Object;

            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.GetItem(itemName)).Returns(expectedItem);

            // Act
            var result = mockDb.Object.GetItem(itemName);

            // Assert
            Assert.AreEqual(expectedItem, result);
        }

        [Test]
        public void GetItem_Should_Return_Null_When_Item_Does_Not_Exist_In_Database()
        {
            // Arrange
            var itemName = "NonExistentItem";

            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.GetItem(itemName)).Returns((IItem)null);

            // Act
            var result = mockDb.Object.GetItem(itemName);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void AddItem_Should_Return_Added_Item()
        {
            // Arrange
            var itemToAdd = new Mock<IItem>().Object;

            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.AddItem(itemToAdd)).Returns(itemToAdd);

            // Act
            var result = mockDb.Object.AddItem(itemToAdd);

            // Assert
            Assert.AreEqual(itemToAdd, result);
        }

        [Test]
        public void AddLogRecord_Should_Call_Method_In_Database()
        {
            // Arrange
            var message = "Test log message";

            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.AddLogRecord(message));

            // Act
            mockDb.Object.AddLogRecord(message);

            // Assert
            mockDb.Verify(db => db.AddLogRecord(message), Times.Once);
        }

        [Test]
        public void IsAvailable_Should_Return_True_When_Database_Is_Available()
        {
            // Arrange
            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.IsAvailable()).Returns(true);

            // Act
            var result = mockDb.Object.IsAvailable();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsAvailable_Should_Return_False_When_Database_Is_Not_Available()
        {
            // Arrange
            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.IsAvailable()).Returns(false);

            // Act
            var result = mockDb.Object.IsAvailable();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
