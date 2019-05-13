using NUnit.Framework;
using SimpleCalculator.FifthLab;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Tests.FifthLab
{
    /// <summary>
    /// Test class.
    /// </summary>
    [TestFixture]
    public class DataStorageTest
    {
        /// <summary>
        /// Test method.
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetNeededInformationAsynchronous_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            const int expectedCountOfUsers = 3;
            const string expectedFirstName = "Best";
            const string expectedLastName = "Student";
            var dataStorage = new DataStorage();

            // Act
            var actual = await dataStorage.GetNeededInformationAsynchronous();

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCountOfUsers, actual.Count);
            Assert.AreEqual(expectedFirstName ,actual.First().FirstName);
            Assert.AreEqual(expectedLastName, actual.First().SecondName);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void GetNeededInformationWithoutAsynchronous_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            const int expectedCountOfUsers = 3;
            const string expectedFirstName = "Best";
            const string expectedSecondName = "Student";
            var dataStorage = new DataStorage();

            // Act
            var actual = dataStorage.GetNeededInformationAsynchronous().Result;

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedCountOfUsers, actual.Count);
            Assert.AreEqual(expectedFirstName, actual.First().FirstName);
            Assert.AreEqual(expectedSecondName, actual.First().SecondName);
        }
    }
}
