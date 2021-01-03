using NUnit.Framework;
using System.Threading;

namespace ClientServerLib.Model.Tests
{
    /// <summary>
    /// Class for testing server class.
    /// </summary>
	[TestFixture()]
	public class ServerTests
	{
        /// <summary>
        /// Test for testing server class.
        /// </summary>
        /// <param name="actualNameOne">Client name.</param>
        /// <param name="actualIp">Ip-adress.</param>
        /// <param name="actualPort">Port connection.</param>
        [TestCase("Ivan", "127.0.0.1", 8895)]
        public void GivenServerWhenInitInstancTheOutIsTwoClients(string actualNameOne, string actualIp, int actualPort)
        {
            //Arrange
            Server tcpServer = new Server(actualPort);
            Thread serverThread = new Thread(new ThreadStart(tcpServer.Start));
            serverThread.Start();

            Client tcpClientOne = new Client(actualNameOne, actualIp, actualPort);
            Thread clientThreadOne = new Thread(new ThreadStart(tcpClientOne.OpenStream));
            clientThreadOne.Start();

            tcpClientOne.OpenStream();

            //Assert
            Assert.AreEqual(tcpServer.ServersClients.Count, 1);
        }
    }
}