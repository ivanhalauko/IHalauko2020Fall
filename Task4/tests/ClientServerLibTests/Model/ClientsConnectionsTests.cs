using NUnit.Framework;
using System.Net.Sockets;

namespace ClientServerLib.Model.Tests
{
	/// <summary>
	/// Class for testing ClientsConnections class.
	/// </summary>
	[TestFixture()]
	public class ClientsConnectionsTests
	{
        /// <summary>
        /// Test case to testing exception.
        /// </summary>
        /// <param name="hostname">Client's name.</param>
        /// <param name="port">Client's Ip-adress.</param>
        [TestCase("Ivan", 8887)]
        public void GivenClientConnectionsWithoutServer_WhenClientIdTcpClientIsNotNull_ThenOutIsException(
            string hostname, int port)
        {
            //Act
            var ex = Assert.Throws<System.Net.Sockets.SocketException>(() => new TcpClient(hostname, port));
            // var ex = Assert.Throws<Exception>(() => new ClientsConnections(tcpClient, clientId));
            //Assert
            //Assert.That(ex.Message, Is.EqualTo("Client with id: " + clientId + " is not conected."));
            Assert.That(ex.Message, Is.EqualTo("Этот хост неизвестен"));
        }
    }
}