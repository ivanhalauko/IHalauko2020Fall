using System;

namespace Serializers.Services.UserException
{
	/// <summary>
	/// Exception class for serializer.
	/// </summary>
	public class SerializerException : Exception
	{
		/// <summary>
		/// Empty constructor.
		/// </summary>
		public SerializerException()
		{
		}

		/// <summary>
		/// Constructor to display the product exception message.
		/// </summary>
		/// <param name="message"></param>
		public SerializerException(string message) : base(message)
		{
		}

		/// <summary>
		/// Method calling user exception if path is not exist.
		/// </summary>
		/// <param name="path">Path param.</param>
		public static void PathExists(string path)
		{
			if (path == null)
				throw new SerializerException($"The path is not: null");
		}
	}
}
