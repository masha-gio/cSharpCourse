using Moq;
using ClassLibrary.Interfaces;

namespace ClassLibraryTest
{
    [TestFixture]
    internal class ILoggerTest
    {
        [Test]
        public void Info_Should_Call_Method_In_Logger()
        {
            // Arrange
            var message = "Test info message";

            var mockLogger = new Mock<ILogger>();
            mockLogger.Setup(logger => logger.Info(message));

            // Act
            mockLogger.Object.Info(message);

            // Assert
            mockLogger.Verify(logger => logger.Info(message), Times.Once);
        }

        [Test]
        public void Warn_Should_Call_Method_In_Logger()
        {
            // Arrange
            var message = "Test warn message";

            var mockLogger = new Mock<ILogger>();
            mockLogger.Setup(logger => logger.Warn(message));

            // Act
            mockLogger.Object.Warn(message);

            // Assert
            mockLogger.Verify(logger => logger.Warn(message), Times.Once);
        }

        [Test]
        public void IsAvailable_Should_Return_True_When_Logger_Is_Available()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            mockLogger.Setup(logger => logger.IsAvailable()).Returns(true);

            // Act
            var result = mockLogger.Object.IsAvailable();

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsAvailable_Should_Return_False_When_Logger_Is_Not_Available()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            mockLogger.Setup(logger => logger.IsAvailable()).Returns(false);

            // Act
            var result = mockLogger.Object.IsAvailable();

            // Assert
            Assert.IsFalse(result);
        }
    }
}
