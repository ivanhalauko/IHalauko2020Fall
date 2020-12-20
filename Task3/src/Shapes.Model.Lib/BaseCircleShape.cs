using System;

namespace Shapes.Model.Lib
{
	/// <summary>
	/// Public base circle class for work. 
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
			Radius = radius;
		}

		/// <summary>
		/// Constructor to cut shape from another.
		/// </summary>
		/// <param name="currentShape">Shape's blank.</param>
		/// <param name="cuttingShape">Cut out shape.</param>
		public BaseCircleShape(BaseShape currentShape, BaseCircleShape cuttingShape) : base(currentShape, cuttingShape)
		{
			UserException.AreaCutting(currentShape, cuttingShape);
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
			return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
		}

		/// <summary>
		/// Method calculate perimetr.
		/// </summary>
		/// <param name="radius">Shape's radius.</param>
		/// <returns>Return shape's perimetr.</returns>
		private double CalculatePerimeter()
		{
			return Math.Round(Math.PI * 2 * Radius, 2);
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
