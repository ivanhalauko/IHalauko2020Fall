namespace ClientServerLib.ServerAndClientEventArgs
{
    /// <summary>
    /// Define a class to hold custom event info.
    /// </summary>
    public class NewMessageToServerEventArgs : NewMessageEventArgs
    {
        /// <summary>
        /// Client id.
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
