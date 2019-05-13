using Moq;
using NUnit.Framework;
using SimpleCalculator;
using SimpleCalculator.ThirdLab;
using System;

namespace Calculator.Tests.ThirdLab
{
    /// <summary>
    /// Test class.
    /// </summary>
    [TestFixture]
    public class ConnectionTests
    {
        // We dont use Dictionary for DB, cause no time for caution. => by Hanz Zimmer

        #region skipped test

        /// <summary>
        /// Skipped test.
        /// </summary>
        [Test]
        [Ignore("Example of ignored test.")]
        public void GetConnection_StateUnderTest_ExpectedBehavior()
        {
            // Arrange

            // Act

            // Assert

        }

        #endregion

        #region by private field and ctor

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void GetConnection_PositiveNumnersAreProvided_Equal()
        {
            // Arrange
            const string expectedConnection = "StringConnection";
            var connectionMock = new Mock<IConnection>();
            connectionMock.Setup(x => x.GetConnection()).Returns(expectedConnection);
            var connection = new Connection(connectionMock.Object);

            // Act
            var actual = connection.GetConnection();

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedConnection, actual);
            connectionMock.Verify(y => y.GetConnection());
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void GetConnection_CheckForExceptionMethodByField_ExceptionThrowed()
        {
            // Arrange
            const string expectedMessage = "Exception of type 'System.Exception' was thrown.";
            var connectionMock = new Mock<IConnection>();
            connectionMock.Setup(x => x.GetConnection()).Throws(new Exception());
            var connection = new Connection(connectionMock.Object);

            // Act
            var actual = Assert.Throws<Exception>(() => connection.GetConnection()); 

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedMessage, actual.Message);
            connectionMock.Verify(y => y.GetConnection());
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void GetConnection_CheckForExceptionCtor_ExceptionThrowed()
        {
            // Arrange 
            const string expectedMessage = "Value cannot be null.";

            // Act
            var actual = Assert.Throws<ArgumentNullException>(() => new Connection(null));

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedMessage, actual.Message);
        }

        #endregion

        #region connection by propertie

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void GetConnection_CheckConnectionMethodByProperty_Equal()
        {
            const string expected = "StringConnection";
            var connectionMock = new Mock<IConnection>();
            connectionMock.Setup(x => x.GetConnection()).Returns("StringConnection");
            var connection = new Connection();
            connection.ConnectionProperty = connectionMock.Object;

            // Act
            var actual = connection.GetConnectionByProperty();

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void GetConnection_CheckForExceptionMethodByProperty_ExceptionThrowed()
        {
            const string expectedMessage = "Exception of type 'System.Exception' was thrown.";
            var connectionMock = new Mock<IConnection>();
            connectionMock.Setup(x => x.GetConnection()).Throws(new Exception());
            var connection = new Connection();
            connection.ConnectionProperty = connectionMock.Object;

            // Act
            var actual = Assert.Throws<Exception>(() => connection.GetConnectionByProperty());

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedMessage, actual.Message);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void GetConnection_CheckForExceptionMethodByPropertyWithNullParameter_ExceptionThrowed()
        {
            const string expectedMessage = "Object reference not set to an instance of an object.";
            var connection = new Connection();
            connection.ConnectionProperty = null;

            // Act
            var actual = Assert.Throws<NullReferenceException>(() => connection.GetConnectionByProperty());

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedMessage, actual.Message);
        }

        #endregion

        #region connection provided by stub class

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void GetConnection_CheckByStubClassOurPropertie_PositiveScenario()
        {
            const string expected = "StringConnection";
            var connection = new Connection();
            connection.ConnectionProperty = new ConnectionStub();

            // Act
            var actual = connection.GetConnectionByProperty();

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test method.
        /// </summary>
        [Test]
        public void GetConnection_CheckByStubClassOurFieldAndCtor_PositiveScenario()
        {
            const string expected = "StringConnection";
            var connection = new Connection();
            connection.ConnectionProperty = new ConnectionStub();

            // Act
            var actual = connection.GetConnectionByProperty();

            // Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Stub class

        /// <summary>
        /// Stub class.
        /// </summary>
        private class ConnectionStub : IConnection
        {
            public string GetConnection()
            {
                return "StringConnection";
            }
        }

        #endregion
    }
}
