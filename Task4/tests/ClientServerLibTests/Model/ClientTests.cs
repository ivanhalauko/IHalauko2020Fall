using System;
using NUnit.Framework;

namespace ClientServerLib.Model.Tests
{
    /// <summary>
    /// Class for testing client class.
    /// </summary>
    [TestFixture()]
    public class ClientTests
    {
        /// <summary>
        /// Test case to testing exception.
        /// </summary>
        /// <param name="actualName">Client's name.</param>
        /// <param name="actualIp">Client's Ip-adress.</param>
        /// <param name="actualPort">Client's port.</param>
        [TestCase("Ivan", "127.0.0.1", 8887)]
        public void GivenClientWithoutServer_WhenNameIpPortIsNotNull_ThenOutIsException(
            string actualName, string actualIp, int actualPort)
        {
            //Act
            var ex = Assert.Throws<Exception>(() => new Client(actualName, actualIp, actualPort));
            //Assert
            Assert.That(ex.Message, Is.EqualTo("Connection Error"));
        }
    }   
}