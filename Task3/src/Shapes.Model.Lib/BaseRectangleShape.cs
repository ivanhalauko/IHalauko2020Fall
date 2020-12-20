using System;

namespace Shapes.Model.Lib
{
	/// <summary>
	/// Public base rectangle class for work. 
	/// </summary>
	public class BaseRectangleShape : BaseShape
	{
		/// <summary>
		/// Property lenght rectangle.
		/// </summary>
		public double Length { get; }

		/// <summary>
		/// Property width rectangle.
		/// </summary>
		public double Width { get; }

		/// <summary>
		/// Property rectangle's area.
		/// </summary>
		public override double Area
		{
			get { return CalculateArea(); }
		}

		/// <summary>
		/// Property rectangle's perimeter.
		/// </summary>
		public override double Perimeter
		{
			get { return CalculatePerimeter(); }
		}

		/// <summary>
		/// Constructor initialized rectangle object with length and widht parametr.
		/// </summary>
		/// <param name="length">Rectangle's length.</param>
		/// <param name="width">Rectangle's width.</param>
		public BaseRectangleShape(double length, double width)
		{
			Length = length;
			Width = width;
		}


		/// <summary>
		/// Constructor to cut shape from another.
		/// </summary>
		/// <param name="currentShape">Shape's blank.</param>
		/// <param name="cuttingShape">Cut out shape.</param>
		public BaseRectangleShape(BaseRectangleShape currentShape, BaseRectangleShape cuttingShape) : base(currentShape, cuttingShape)
		{
			UserException.AreaCutting(currentShape, cuttingShape);
		}

		/// <summary>
		/// Method calculate shape's area.
		/// </summary>
		/// <param name="length">Shape's lenght.</param>
		/// <param name="width">Shape's width.</param>
		/// <returns>Return shape's perimetr.</returns>
		private double CalculateArea()
		{
			return Length * Width;
		}

		/// <summary>
		/// Method calculate shape's perimeter.
		/// </summary>
		/// <param name="length">Shape's lenght.</param>
		/// <param name="width">Shape's width.</param>
		/// <returns>Return shape's perimetr.</returns>
		private double CalculatePerimeter()
		{
			return 2 * Length + 2 * Width;
		}

		/// <summary>
		/// Comparison one figure with another.
		/// </summary>
		/// <param name="obj">Comparer parameter.</param>
		/// <returns>Return "true" if equal and "false" if not equal.</returns>
		public override bool Equals(Object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			BaseRectangleShape r = (BaseRectangleShape)obj;
			return Length.Equals(r.Length) && Width.Equals(r.Width);
		}

		/// <summary>
		/// Calculate hash code for comparison one figure with another.
		/// </summary>
		/// <returns>Hash code.</returns>
		public override int GetHashCode()
		{
			return Tuple.Create(Length, base.GetHashCode()).GetHashCode();
		}
		/// <summary>
		/// Conversion class members in string format.
		/// </summary>
		/// <returns>Return members in string format.</returns>
		public override string ToString()
		{
			return string.Format("{0};{1};{2}", base.ToString(), Length, Width);
		}
	}
}
