using System;

namespace ClientServerLib.ServerAndClientEventArgs
{
    /// <summary>
    /// Define a base class to hold custom event info.
    /// </summary>
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
