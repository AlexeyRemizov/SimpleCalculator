
using NUnit.Framework;

namespace Calculator.Tests
{
    /// <summary>
    /// Test class.
    /// </summary>
    [TestFixture]
    public class CalculatorTests
    {
        #region Tests

        #region Add method

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Add_PositiveNumnersAreProvided_Equal()
        {
            // Arrange
            const int expected = 5;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Add(2, 3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Add_PositiveNumbersAreProvided_NotEqual()
        {
            const int expected = 5;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Add(1, 3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Add_NegativeNumbersAreProvided_Equal()
        {
            const int expected = -4;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Add(-1, -3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Add_NegativeNumbersAreProvided_NotEqual()
        {
            const int expected = -5;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Add(-1, -3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        #endregion

        #region Sub method

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Sub_PositiveNumbersAreProvided_AreEqual()
        {
            // Arrange
            const int expected = -2;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Sub(1, 3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Sub_PositiveNumbersAreProvided_AreNotEqual()
        {
            // Arrange
            const int expected = -7;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Sub(5, 3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Sub_NegativeNumbersAreProvided_AreEqual()
        {
            // Arrange
            const int expected = -7;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Sub(-9, -2);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Sub_NegativeNumbersAreProvided_AreNotEqual()
        {
            // Arrange
            const int expected = -7;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Sub(-9, 3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        #endregion

        #region Mult

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Mult_PositiveNumbersAreProvided_AreEqual()
        {
            // Arrange
            const int expected = 15;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Mult(5, 3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Mult_PositiveNumbersAreProvided_AreNotEqual()
        {
            // Arrange
            const int expected = 15;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Mult(4, 4);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Mult_NegativeNumbersAreProvided_AreEqual()
        {
            // Arrange
            const int expected = 18;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Mult(-9, -2);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Mult_NegativeNumbersAreProvided_AreNotEqual()
        {
            // Arrange
            const int expected = -18;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Mult(-9, -2);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        #endregion

        #region Div method

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Div_PositiveNumbersAreProvided_AreEqual()
        {
            // Arrange
            const int expected = 3;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Div(6, 2);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Div_PositiveNumbersAreProvided_AreNotEqual()
        {
            // Arrange
            const int expected = 3;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Div(2, 6);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Div_NegativeNumbersAreProvided_AreEqual()
        {
            // Arrange
            const int expected = 3;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Div(-9, -3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void Div_NegativeNumbersAreProvided_AreNotEqual()
        {
            // Arrange
            const int expected = -3;
            var calculator = new SimpleCalculator.FirstLab.Calculator();

            // Act
            var actual = calculator.Div(-9, -3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        #endregion

        #endregion
    }
}

