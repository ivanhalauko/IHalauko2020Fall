using System;

namespace Shapes.Model.Lib
{
	/// <summary>
	/// Shapes user exception class.
	/// </summary>
	public class ShapesUserException : Exception
	{
		/// <summary>
		/// Constrictor with one parameter.
		/// </summary>
		/// <param name="message"></param>
		public ShapesUserException(string message) : base(message)
		{
		}

		/// <summary>
		/// Constructor to cut shape from another.
		/// </summary>
		/// <param name="currentShape">Shape's blank.</param>
		/// <param name="cuttingShape">Cut out shape.</param>
		internal static void AreaCutting(BaseShape currentShape, BaseShape cuttingShape)
		{
			if (cuttingShape.Area > currentShape.Area)
			{
				throw new ShapesUserException($"The area cutting shape {cuttingShape.Area} can not be larger than the current shape{currentShape.Area}");
			}
		}

		/// <summary>
		/// Method calling user exception if value is negative.
		/// </summary>
		/// <param name="value">Value param.</param>
		public static void SetIncorrectDoubleValue(double value)
		{
			if (value < 0)
				throw new ShapesUserException($"The value can not be negative");
		}

		/// <summary>
		/// Method calling user exception if value is negative.
		/// </summary>
		/// <param name="value">Value param.</param>
		public static void SetIncorrectDoubleValueZero(double value)
		{
			if (value == 0)
				throw new ShapesUserException($"The value can not be zero");
		}
	}
}
