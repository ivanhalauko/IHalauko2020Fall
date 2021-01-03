using System;

namespace ClientServerLib.ServerAndClientEventArgs
{
	public class NewMessageEventArgs : EventArgs
	{
        /// <summary>
        /// Input message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Constructor for <see cref="NewMessageEventArgs"/>
        /// </summary>
        /// <param name="message">Input message.</param>
        public NewMessageEventArgs(string message)
        {
            Message = message;
        }
    }
}
