using Figures.Model.Lib.Enums;
using Figures.Model.Lib.Figures;
using Shapes.Model.Lib;
using System;

namespace XMLStreamReaderWriter
{
	/// <summary>
	/// String reader class.
	/// </summary>
	public class StringReader
	{
		/// <summary>
		/// Static method convert String type name of color to enum Colors type
		/// </summary>
		/// <param name="figureColor"></param>
		/// <returns></returns>
		static ColorEnum GetColorFromString(string figureColor)
		{
			return (ColorEnum)Enum.Parse(typeof(ColorEnum), figureColor);
		}

		/// <summary>
		/// Static method convert String type of abstract figure to AbstractFigure type
		/// </summary>
		/// <param name="inputString"></param>
		/// <returns></returns>
		public static BaseShape GetFigureFromString(string inputString)
		{
			BaseShape figure;
			string[] subStrings = inputString.Split('\u0027');

			switch (subStrings[1])
			{
				case "FilmCircle":
					figure = new FilmCircle(Double.Parse(subStrings[3]));
					break;

				case "FilmRectangle":
					figure = new FilmRectangle(Double.Parse(subStrings[3]), Double.Parse(subStrings[5]));
					break;

				case "PaperCircle":
					figure = new PaperCircle(Double.Parse(subStrings[3]), GetColorFromString(subStrings[5]));
					break;

				case "PaperRectangle":
					figure = new PaperRectangle(Double.Parse(subStrings[3]), Double.Parse(subStrings[5]), GetColorFromString(subStrings[7]));
					break;

				default:
					throw new Exception("Figure does not exist");
			}

			return figure;
		}
	}
}
