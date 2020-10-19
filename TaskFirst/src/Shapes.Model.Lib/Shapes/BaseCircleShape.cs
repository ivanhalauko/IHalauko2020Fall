using System;

namespace Shapes.Model.Lib.Shapes
{
	/// <summary>
	/// Class base circle shape.
	/// </summary>
	public class BaseCircleShape : BaseShape
	{
		/// <summary>
		/// Property radius.
		/// </summary>
		public double Radius { get; }

		/// <summary>
		/// Constructor initialized circle object with radius parameter.
		/// </summary>
		/// <param name="radius">Return radius value.</param>
		public BaseCircleShape(double radius)
		{
			Radius = Math.Abs(radius);
		}

		/// <summary>
		/// Property circle's area.
		/// </summary>
		public override double Area
		{
			get { return CalculateArea(); }
		}

		/// <summary>
		/// Property circles's perimeter.
		/// </summary>
		public override double Perimeter
		{
			get { return CalculatePerimeter(); }
		}

		/// <summary>
		/// Method calculate shape's area.
		/// </summary>
		/// <param name="radius">Shape's radius.</param>
		/// <returns>Return shape's area.</returns>
		private double CalculateArea()
		{
			if (Radius != 0)
			{
				return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
			}
			else
			{
				throw new Exception("Circle's radius have null value.");
			}
		}

		/// <summary>
		/// Method calculate perimetr.
		/// </summary>
		/// <param name="radius">Shape's radius.</param>
		/// <returns>Return shape's perimetr.</returns>
		private double CalculatePerimeter()
		{
			if (Radius != 0)
			{
				return Math.Round(Math.PI * 2 * Radius, 2);
			}
			else
			{
				throw new Exception("Circle's radius have null value.");
			}
		}

		/// <summary>
		/// Comparison one figure with another.
		/// </summary>
		/// <param name="obj">Comparer parameter.</param>
		/// <returns>Return "true" if equal and "false" if not equal.</returns>
		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			BaseCircleShape r = (BaseCircleShape)obj;
			return Radius.Equals(r.Radius);
		}
		/// <summary>
		/// Calculate hash code for comparison one figure with another.
		/// </summary>
		/// <returns>Hash code.</returns>
		public override int GetHashCode()
		{
			return Tuple.Create(Radius, base.GetHashCode()).GetHashCode();
		}

		/// <summary>
		/// Conversion class members in string format.
		/// </summary>
		/// <returns>Return members in string format.</returns>
		public override string ToString()
		{
			return string.Format("{0};{1}", base.ToString(), Radius);
		}
	}
}
