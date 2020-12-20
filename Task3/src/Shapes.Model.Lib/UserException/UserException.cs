using System;

namespace Shapes.Model.Lib
{
	public class UserException : Exception
	{
		/// <summary>
		/// Constrictor with one parameter.
		/// </summary>
		/// <param name="message"></param>
		public UserException(string message) : base(message)
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
				throw new UserException($"The area cutting shape {cuttingShape.Area} can not be larger than the current shape{currentShape.Area}");
			}
		}
	}
}
