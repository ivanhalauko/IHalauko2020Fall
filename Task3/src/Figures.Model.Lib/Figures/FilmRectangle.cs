using Figures.Model.Lib.Interfaces;
using Shapes.Model.Lib;

namespace Figures.Model.Lib.Figures
{
	/// <summary>
	/// Film rectangle figures class.
	/// </summary>
	public class FilmRectangle : BaseRectangleShape, IFilm
	{
		/// <summary>
		/// Constuctor with two parameters.
		/// </summary>
		/// <param name="length">Lenght parameter.</param>
		/// <param name="width">Width parameter.</param>
		public FilmRectangle(double length, double width) : base(length, width)
		{
		}

		/// <summary>
		/// Constructor to cut shape from another.
		/// </summary>
		/// <param name="currentShape">Shape's blank.</param>
		/// <param name="cuttingShape">Shape which Cut out.</param>
		public FilmRectangle(BaseRectangleShape currentShape, BaseRectangleShape cuttingShape) : base(currentShape, cuttingShape)
		{
		}
	}
}
