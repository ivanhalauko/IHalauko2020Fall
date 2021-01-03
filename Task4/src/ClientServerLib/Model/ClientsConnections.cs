using System;
using System.Text;
using System.Net.Sockets;
using System.Diagnostics;

namespace ClientServerLib.Model
{
    /// <summary>
    /// Class create new connection on server.
    /// </summary>
    public class ClientsConnections
    {
        /// <summary>
        /// Tcp client for to connect to the server.
        /// </summary>
        public TcpClient TcpClient { get; private set; }

        /// <summary>
        /// Client id which the server issues.
        /// </summary>
        public int ClientId { get; private set; }

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
        public ClientsConnections(TcpClient tcpClient, int clientId)
        {
            TcpClient = tcpClient;
            ClientId = clientId;
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
                        string message = "Message";                     
                        data = Encoding.Unicode.GetBytes(message);
                        NetworkStream.Write(data, 0, data.Length);
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
    }
}
