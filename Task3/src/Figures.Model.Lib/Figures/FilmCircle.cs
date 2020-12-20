using Figures.Model.Lib.Interfaces;
using Shapes.Model.Lib;

namespace Figures.Model.Lib.Figures
{
	/// <summary>
	/// Film circle figures class.
	/// </summary>
	public class FilmCircle : BaseCircleShape, IFilm
	{
		/// <summary>
		/// Constructor with two parameters.
		/// </summary>
		/// <param name="radius">Radius parameter.</param>
		public FilmCircle(double radius) : base(radius)
		{
		}

		/// <summary>
		/// Constructor to cut shape from another.
		/// </summary>
		/// <param name="currentShape">Shape's blank.</param>
		/// <param name="cuttingShape">Shape which Cut out.</param>
		public FilmCircle(BaseCircleShape currentShape, BaseCircleShape cuttingShape) : base(currentShape, cuttingShape)
		{
		}
	}
}
