using ClassLibrary.Classes;
using ClassLibrary.Interfaces;
using NUnit.Framework;
using Moq;

namespace ClassLibraryTest
{
    [TestFixture]
    internal class ShopLoggerTest
    {
        [Test]
        public void Info_Method_Should_Add_Info_Log_Record()
        {
            // Arrange
            string message = "Test message";
            string expectedLogMessage = $"INFO: {message}";

            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.AddLogRecord(It.IsAny<string>()));

            var shopLogger = new ShopLogger(mockDb.Object);

            // Act
            shopLogger.Info(message);

            // Assert
            mockDb.Verify(db => db.AddLogRecord(expectedLogMessage), Times.Once);
        }

        [Test]
        public void Warn_Method_Should_Add_Warn_Log_Record()
        {
            // Arrange
            string message = "Test message";
            string expectedLogMessage = $"WARN: {message}";

            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.AddLogRecord(It.IsAny<string>()));

            var shopLogger = new ShopLogger(mockDb.Object);

            // Act
            shopLogger.Warn(message);

            // Assert
            mockDb.Verify(db => db.AddLogRecord(expectedLogMessage), Times.Once);
        }

        [Test]
        public void IsAvailable_Method_Should_Return_True_When_Db_Is_Available()
        {
            // Arrange
            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.IsAvailable()).Returns(true);

            var shopLogger = new ShopLogger(mockDb.Object);

            // Act
            bool result = shopLogger.IsAvailable();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsAvailable_Method_Should_Return_False_When_Db_Is_Not_Available()
        {
            // Arrange
            var mockDb = new Mock<IDb>();
            mockDb.Setup(db => db.IsAvailable()).Returns(false);

            var shopLogger = new ShopLogger(mockDb.Object);

            // Act
            bool result = shopLogger.IsAvailable();

            // Assert
            Assert.IsFalse(result);
        }
    }
}