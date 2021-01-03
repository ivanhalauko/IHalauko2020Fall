using ClientServerLib.Repositories;
using NUnit.Framework;
using System.Collections.Generic;
using System.Net;
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

        /// <summary>
        /// Test case with two clients connection on the server.
        /// </summary>
        /// <param name="serverName">Server name.</param>
        /// <param name="serverMessage">Server message.</param>
        /// <param name="clientOneId">Client one id.</param>
        /// <param name="clientOneName">Client one name.</param>
        /// <param name="clientOneMessage">Client one message.</param>
        /// <param name="clientTwoId">Client two id.</param>
        /// <param name="clientTwoName">Client two name.</param>
        /// <param name="clientTwoMessage">Client two message.</param>
        [TestCase(
            "ServerOne", "ServerMessage",
            0, "FirstClient", "FirstClientMessage",
            1, "SecondClient", "SecondClientMessage")]
        public void GetServerMessageRepository_WhenTwoClientConnection(string serverName, string serverMessage,
            int clientOneId, string clientOneName, string clientOneMessage,
            int clientTwoId, string clientTwoName, string clientTwoMessage)
        {
            //Arrange
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            List<string> expectedClientOneMessage = new List<string>() { $"Id: '{clientOneId}'; Client name: '{clientOneName}'; Message: '{clientOneMessage}'." };
            List<string> expectedClientTwoMessage = new List<string>() { $"Id: '{clientTwoId}'; Client name: '{clientTwoName}'; Message: '{clientTwoMessage}'." };

            List<ServerMessageRepository> expectedServerMessageRepositories = new List<ServerMessageRepository>()
            {
                new ServerMessageRepository() { Messages = expectedClientOneMessage },
                new ServerMessageRepository() { Messages = expectedClientTwoMessage }
            };

            //Act

            //Initial server
            Server server = new Server(serverName, IPAddress.Any, 8880) { Message = serverMessage };
            Thread thread = new Thread(new ThreadStart(server.Start));
            thread.Start();

            List<ServerMessageRepository> actualServerMessageRepository = server.ServerMessageRepositories;

            //Initial client one
            Client clientOne = new Client(clientOneName, ipAddress, 8880) { Message = clientOneMessage };
            Thread clientThreadOne = new Thread(new ThreadStart(clientOne.OpenStream));
            clientThreadOne.Start();

            //Initial client two
            Client clientTwo = new Client(clientTwoName, ipAddress, 8880) { Message = clientTwoMessage };
            Thread clientThreadTwo = new Thread(new ThreadStart(clientTwo.OpenStream));
            clientThreadTwo.Start();

            clientThreadOne.Join();
            clientThreadTwo.Join(100);

            //Assert
            Assert.AreEqual(expectedServerMessageRepositories, actualServerMessageRepository);
        }
    }
}