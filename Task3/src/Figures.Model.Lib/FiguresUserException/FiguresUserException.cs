using Figures.Model.Lib.Enums;
using Figures.Model.Lib.Interfaces;
using Shapes.Model.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Model.Lib.FigUserException
{
	/// <summary>
	/// Exception class for shapes.
	/// </summary>
	public class FiguresUserException : Exception
	{
		/// <summary>
		/// Constrictor with one parameter.
		/// </summary>
		/// <param name="message"></param>
		public FiguresUserException(string message) : base(message)
		{
		}

		/// <summary>
		/// Constructor to cut shape from another.
		/// </summary>
		/// <param name="currentShapeColor">Shape's blank.</param>
		/// <param name="cuttingShapeColor">Cut out shape.</param>
		internal static void ColorEqualsHandler(ColorEnum currentShapeColor, ColorEnum cuttingShapeColor)
		{
			if (currentShapeColor != cuttingShapeColor)
				throw new FiguresUserException($"The color of the cutting shape {cuttingShapeColor.ToString()} have to equal the current shape {currentShapeColor.ToString()}");
		}

		/// <summary>
		/// Constructor to paint figure to another color.
		/// </summary>
		/// <param name="isFigurePainted">Shape's blank.</param>
		/// <param name="secondFiguresColor">Cut out shape.</param>
		internal static void PaintingFigureHandler(bool isFigurePainted, ColorEnum secondFiguresColor)
		{
			bool IsFigureSecondPainted = false;
			if (secondFiguresColor != ColorEnum.IsNotColoured)
			{
				IsFigureSecondPainted = true;
			}
			if (isFigurePainted == IsFigureSecondPainted)
				throw new FiguresUserException($"The figure colored  {secondFiguresColor.ToString()} you can not change color.");
		}

		/// <summary>
		/// Constructor to paint figure to another color.
		/// </summary>
		/// <param name="isFigurePainted">Shape's blank.</param>
		/// <param name="secondFiguresColor">Cut out shape.</param>
		internal static void PaintingClearFigureHandler(bool isFigurePainted, ColorEnum secondFiguresColor)
		{
			if ((isFigurePainted==false)&&(secondFiguresColor != ColorEnum.IsNotColoured))
			{
				throw new FiguresUserException($"The figure painted to {secondFiguresColor.ToString()} sucсesessfully.");		
			}		
		}
	}
}
