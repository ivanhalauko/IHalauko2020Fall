namespace ClientServerLib.ServerAndClientEventArgs
{
    public class NewMessageToServerEventArgs : NewMessageEventArgs
    {
        /// <summary>
        /// Clietn id.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Constructor <see cref="NewMessageToServerEventArgs"/>
        /// </summary>
        /// <param name="message">New message.</param>
        /// <param name="id">Client id.</param>
        public NewMessageToServerEventArgs(string message, int id) : base(message)
        {
            Id = id;
        }
    }
}
