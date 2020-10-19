using System;

namespace Shapes.Model.Lib.Shapes
{
	public class BaseSquareShape : BaseShape
	{
		/// <summary>
		/// Property lenght rectangle.
		/// </summary>
		public double LengthOfSide { get; }

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
		public BaseSquareShape(double lengthOfSide)
		{
			LengthOfSide = Math.Abs(lengthOfSide);
		}

		/// <summary>
		/// Method calculate shape's area.
		/// </summary>
		/// <param name="length">Shape's lenght.</param>
		/// <param name="width">Shape's width.</param>
		/// <returns>Return shape's perimetr.</returns>
		private double CalculateArea()
		{
			if (LengthOfSide != 0)
			{
				return LengthOfSide * LengthOfSide;
			}
			else
			{
				throw new Exception("Square's sides have null value.");
			}
		}

		/// <summary>
		/// Method calculate shape's perimeter.
		/// </summary>
		/// <param name="length">Shape's lenght.</param>
		/// <param name="width">Shape's width.</param>
		/// <returns>Return shape's perimetr.</returns>
		private double CalculatePerimeter()
		{
			if (LengthOfSide != 0)
			{
				return 4 * LengthOfSide;
			}
			else
			{
				throw new Exception("Square's sides have null value.");
			}
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
			BaseSquareShape r = (BaseSquareShape)obj;
			return LengthOfSide.Equals(r.LengthOfSide);
		}

		/// <summary>
		/// Calculate hash code for comparison one figure with another.
		/// </summary>
		/// <returns>Hash code.</returns>
		public override int GetHashCode()
		{
			return Tuple.Create(LengthOfSide, base.GetHashCode()).GetHashCode();
		}
		/// <summary>
		/// Conversion class members in string format.
		/// </summary>
		/// <returns>Return members in string format.</returns>
		public override string ToString()
		{
			return string.Format("{0};{1}", base.ToString(), LengthOfSide);
		}
	}
}
