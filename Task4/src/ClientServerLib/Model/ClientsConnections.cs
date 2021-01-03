using System;
using System.Text;
using System.Net.Sockets;
using System.Diagnostics;
using ClientServerLib.ServerAndClientEventArgs;
using ClientServerLib.Repositories;

namespace ClientServerLib.Model
{
    /// <summary>
    /// Class create new connection on server.
    /// </summary>
    public class ClientsConnections
    {
        /// <summary>
        /// New message event.
        /// </summary>
        public event EventHandler<NewMessageToServerEventArgs> NewMessage;

        /// <summary>
        /// Tcp client for to connect to the server.
        /// </summary>
        public TcpClient TcpClient { get; private set; }

        /// <summary>
        /// Client id which the server issues.
        /// </summary>
        public int ClientId { get; private set; }

        /// <summary>
        /// Server to which client is connected.
        /// </summary>
		public Server Server { get; private set; }

		/// <summary>
		/// Through this object, you can send messages to the server or, conversely, receive data from the server.
		/// </summary>
		public NetworkStream NetworkStream { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="tcpClient">Tcp client for to connect to the server.</param>
        /// <param name="server">The server to which the client is connected.</param>
        /// <param name="clientId">Client id which the server issues.</param>
        public ClientsConnections(TcpClient tcpClient,Server server, int clientId)
        {
            TcpClient = tcpClient;
            ClientId = clientId;
            Server = server;
        }

        /// <summary>
        /// Method for exchanging messages with the client.
        /// </summary>
        public void OpenStream()
        {
            try
            {
                NetworkStream = TcpClient.GetStream();
                byte[] data = new byte[64];
                while (true)
                {
                    try
                    {
                        string message = NetworkStreamIO.GetMessage(NetworkStream);
                        GetNewMessage(message, ClientId);
                        NetworkStreamIO.SendMessage("Message from server received, Транслитом: сообщение от сервера принято", NetworkStream);
                    }
                    catch (Exception)
                    {
                        Debug.WriteLine("Client with id: " + ClientId + " disconected.");
                        throw new Exception("Client with id: " + ClientId + " is not conected.");             
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            finally
            {
                if (NetworkStream != null)
                    NetworkStream.Close();

                if (TcpClient != null)
                    TcpClient.Close();
            }
        }
        /// <summary>
        /// Used to synchronously call the methods supported by the delegate object.
        /// </summary>
        /// /// <param name="e"> Type to receive a message when an event occurs. </param>
        protected void OnNewMessage(NewMessageToServerEventArgs e)
        {
            NewMessage?.Invoke(this, e);
        }

        /// <summary>
        /// Method for notifying receipt of a new message.
        /// </summary>
        /// <param name="message">New message.</param>
        /// <param name="clientId">Client id.</param>
        public void GetNewMessage(string message, int clientId)
        {
            NewMessageToServerEventArgs e = new NewMessageToServerEventArgs(message, clientId);
            OnNewMessage(e);
        }
    }
}
