using ClientServerLib.Model;
using NUnit.Framework;
using System.Threading;

namespace ClientServerLib.Repositories.Tests
{
    /// <summary>
    /// Class for testing class.
    /// </summary>
    [TestFixture()]
    public class ServerMessageRepositoryTests
    {
        /// <summary>
        /// Test method for check up transliteration method.
        /// </summary>
        /// <param name="actualName">Name.</param>
        /// <param name="actualIp">IP-adress.</param>
        /// <param name="actualPort">Connection port.</param>
        [TestCase("Ivan", "127.0.0.1", 8884)]
        public void GivenServerMessageRepositoryTheOutIsConnectionError(string actualName, string actualIp, int actualPort)
        {
            //Arrange
            Server tcpServer = new Server(actualPort);
            Thread serverThread = new Thread(new ThreadStart(tcpServer.Start));
            serverThread.Start();

            Client tcpClient = new Client(actualName, actualIp, actualPort);
            ServerMessageRepository messagesFromServer = new ServerMessageRepository(tcpClient);

            tcpClient.OpenStream();

            //Assert
            Assert.AreEqual("Message from server received, Translitom: soobshchenie ot servera prinyato", messagesFromServer.Messages[0]);
        }
    }
}