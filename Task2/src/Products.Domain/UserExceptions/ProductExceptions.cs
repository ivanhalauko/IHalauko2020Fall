using System;

namespace Products.Domain.UserExceptions
{
	public class ProductExceptions : Exception
	{
		/// <summary>
		/// Empty constructor.
		/// </summary>
		public ProductExceptions()
		{
		}

		/// <summary>
		/// Constructor to display the product exception message.
		/// </summary>
		/// <param name="message"></param>
		public ProductExceptions(string message) : base(message)
		{
		}

		/// <summary>
		/// Method calling user exception if value is negative.
		/// </summary>
		/// <param name="value">Value param.</param>
		public static void SetIncorrectDecimalValue(decimal value)
		{
			if (value < 0)
				throw new ProductExceptions($"The value can not be negative");
		}

		/// <summary>
		/// Method calling user exception if value is negative.
		/// </summary>
		/// <param name="value">Value param.</param>
		public static void SetIncorrectDoubleValue(double value)
		{
			if (value < 0)
				throw new ProductExceptions($"The double value can not be negative");
		}

		/// <summary>
		/// Method calling user exception if value is negative.
		/// </summary>
		/// <param name="value">Value param.</param>
		public static void SetIncorrectIntValue(int value)
		{
			if (value < 0)
				throw new ProductExceptions($"The Int value can not be negative");
		}

		/// <summary>
		/// Method calling user exception if value is negative.
		/// </summary>
		/// <param name="value">Value param.</param>
		public static void SetIncorrectStringValue(string value)
		{
			if (value == null)
				throw new ProductExceptions($"The string value can not be null");
		}
	}
}
