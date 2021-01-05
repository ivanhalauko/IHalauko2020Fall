using System;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Diagnostics;
using System.Collections.Generic;
using ClientServerLib.Repositories;

namespace ClientServerLib.Model
{
    /// <summary>
    /// Main server class.
    /// </summary>
    public class Server
    {
        /// <summary>
        /// Property name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Property mMessage.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Property IPAddress.
        /// </summary>
        public IPAddress IPAddress { get; }

        /// <summary>
        /// Field TcpListener's class.
        /// </summary>
        static TcpListener tcpListener;

        /// <summary>
        /// Server port.
        /// </summary>
        public int Port { get; private set; }

        /// <summary>
        /// List of client connections on the server.
        /// </summary>
        public List<ClientsConnections> ServersClients { get; private set; }

        /// <summary>
        /// A list to store each client’s messages.
        /// </summary>
        public List<ClientMessageRepository> MessagesFromClients { get; private set; }

        /// <summary>
        /// A list to store each client’s messages.
        /// </summary>
        public List<ServerMessageRepository> ServerMessageRepositories { get; private set; }

        /// <summary>
        /// Constructor <see cref="Server"/>
        /// </summary>
        /// <param name="port">Server port.</param>
        public Server(int port)
        {
            Port = port;
        }

        /// <summary>
        /// Constructor <see cref="Server"/>
        /// </summary>
        /// <param name="name">Name parameter.</param>
        /// <param name="ipAddress">IpAddress parameter.</param>
        /// <param name="port">Server port.</param>
        public Server(string name, IPAddress ipAddress, int port) : this(port)
        {
            Name = name;
            Port = port;
            IPAddress = ipAddress;
            tcpListener = new TcpListener(IPAddress, Port);
            ServerMessageRepositories = new List<ServerMessageRepository>();
        }

        /// <summary>
        /// Server launch.
        /// </summary>
        public void Start()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, Port);
                tcpListener.Start();
                Debug.WriteLine("Waiting for connection... ");
                int clientId = 0;

                while (true)
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    Debug.WriteLine(String.Format("Client with id: {0} connected.", clientId));
                    ClientsConnections serverClient = new ClientsConnections(client, this, clientId);
                    Thread listenThread = new Thread(new ThreadStart(serverClient.OpenStream));
                    listenThread.Start();

                    MessagesFromClients.Add(new ClientMessageRepository(serverClient));
                    clientId++;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                if (tcpListener != null)
                {
                    Debug.WriteLine("Server stop");
                    tcpListener.Stop();
                }
            }
        }

        /// <summary>
        /// Adding a new connected client to the collection.
        /// </summary>
        /// <param name="newClientOnTheServer"> A new client on the server.</param>
        internal void AddClientConnection(ClientsConnections newClientOnTheServer)
        {
            ServersClients.Add(newClientOnTheServer);
        }
    }
}
