using NUnit.Framework;
using System;
using Moq;
using SimpleCalculator.SecondLab;

namespace Calculator.Tests.SecondLab
{
    /// <summary>
    /// Test class.
    /// </summary>
    [TestFixture]
    public class EasyCalculatorTests
    {
        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Add_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var addMethodMock = new Mock<IAddMethod>();
            addMethodMock.Setup(x => x.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(5);
            var calculator = new EasyCalculator();

            // Act
            var actual = calculator.Add(addMethodMock.Object, 3, 5);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            addMethodMock.Verify(y => y.Add(It.IsAny<int>(), It.IsAny<int>()));
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Add_StateUnderTest1_ExpectedBehavior()
        {
            // Arrange
            var addMethodMock = new Mock<IAddMethod>();
            addMethodMock.Setup(x => x.Add(3, 4)).Returns(7);
            var calculator = new EasyCalculator();

            // Act
            var actual = calculator.Add(addMethodMock.Object, 3, 5);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            addMethodMock.Verify(y => y.Add(It.IsAny<int>(), It.IsAny<int>()));
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Add_StateUnderTest_ExceptionThrowed()
        {
            // Arrange
            const string expectedMessage = "Operation is not valid due to the current state of the object.";
            var addMethodMock = new Mock<IAddMethod>();
            addMethodMock.Setup(x => x.Add(It.IsAny<int>(), It.IsAny<int>())).Throws(new InvalidOperationException());
            var calculator = new EasyCalculator();

            // Act
            var actual = Assert.Throws<InvalidOperationException>(() => calculator.Add(addMethodMock.Object, 3, 5));

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedMessage, actual.Message);
            addMethodMock.Verify(y => y.Add(It.IsAny<int>(), It.IsAny<int>()));
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Add_StateUnderTest1_ExceptionThrowed()
        {
            // Arrange
            const string expectedMessage = "Exception of type 'System.Exception' was thrown.";
            var addMethodMock = new Mock<IAddMethod>();
            addMethodMock.Setup(x => x.AdditionalMethod()).Throws(new Exception());
            var calculator = new EasyCalculator();

            // Act
            var actual = Assert.Throws<Exception>(() => calculator.Add(addMethodMock.Object, 3, 5));

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedMessage, actual.Message);
            addMethodMock.Verify(y => y.AdditionalMethod(), Times.Once);
            addMethodMock.Verify(y => y.Add(It.IsAny<int>(), It.IsAny<int>()), Times.Never);
        }
    }
}
