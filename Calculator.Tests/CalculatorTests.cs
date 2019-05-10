using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        #region Tests

        #region Add method

        [Test]
        public void Add_PositiveNumnersAreProvided_Equal()
        {
            // Arrange
            const int expected = 5;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Add(2, 3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_PositiveNumbersAreProvided_NotEqual()
        {
            const int expected = 5;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Add(1, 3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void Add_NegativeNumbersAreProvided_Equal()
        {
            const int expected = -4;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Add(-1, -3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Add_NegativeNumbersAreProvided_NotEqual()
        {
            const int expected = -5;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Add(-1, -3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        #endregion

        #region Sub method

        [Test]
        public void Sub_PositiveNumbersAreProvided_AreEqual()
        {
            // Arrange
            const int expected = -2;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Sub(1,3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sub_PositiveNumbersAreProvided_AreNotEqual()
        {
            // Arrange
            const int expected = -7;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Sub(5, 3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void Sub_NegativeNumbersAreProvided_AreEqual()
        {
            // Arrange
            const int expected = -7;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Sub(-9, -2);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Sub_NegativeNumbersAreProvided_AreNotEqual()
        {
            // Arrange
            const int expected = -7;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Sub(-9, 3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        #endregion

        #region Mult

        [Test]
        public void Mult_PositiveNumbersAreProvided_AreEqual()
        {
            // Arrange
            const int expected = 15;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Mult(5, 3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Mult_PositiveNumbersAreProvided_AreNotEqual()
        {
            // Arrange
            const int expected = 15;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Mult(4, 4);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void Mult_NegativeNumbersAreProvided_AreEqual()
        {
            // Arrange
            const int expected = 18;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Mult(-9, -2);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Mult_NegativeNumbersAreProvided_AreNotEqual()
        {
            // Arrange
            const int expected = -18;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Mult(-9, -2);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        #endregion

        #region Div method

        [Test]
        public void Div_PositiveNumbersAreProvided_AreEqual()
        {
            // Arrange
            const int expected = 3;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Div(6, 2);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Div_PositiveNumbersAreProvided_AreNotEqual()
        {
            // Arrange
            const int expected = 3;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Div(2, 6);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void Div_NegativeNumbersAreProvided_AreEqual()
        {
            // Arrange
            const int expected = 3;
            var calculator = new SimpleCalculator.Calculator();

            // Act
            var actual = calculator.Div(-9, -3);

            // Assert
            Assert.IsNotEmpty(actual.ToString());
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Div_NegativeNumbersAreProvided_AreNotEqual()
        {
            // Arrange
            const int expected = -3;
            var calculator = new SimpleCalculator.Calculator();

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
