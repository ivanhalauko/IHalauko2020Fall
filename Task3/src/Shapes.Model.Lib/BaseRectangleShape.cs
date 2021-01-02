using System;

namespace Shapes.Model.Lib
{
	/// <summary>
	/// Public base rectangle class for work. 
	/// </summary>
	public class BaseRectangleShape : BaseShape
	{
		/// <summary>
		/// Shape's length.
		/// </summary>
		private double length;

		/// <summary>
		/// Shape's width.
		/// </summary>
		private double width;

		/// <summary>
		/// Property lenght rectangle.
		/// </summary>
		public double Length
		{
			set
			{
				if (value == 0)
					ShapesUserException.SetIncorrectDoubleValueZero(value);
				if (value < 0)
					ShapesUserException.SetIncorrectDoubleValue(value);
				length = value;
			}
			get { return length; }
		}

		/// <summary>
		/// Property width rectangle.
		/// </summary>
		public double Width 
		{
			set
			{
				if (value == 0)
					ShapesUserException.SetIncorrectDoubleValueZero(value);
				if (value < 0)
					ShapesUserException.SetIncorrectDoubleValue(value);
				width = value;
			}
			get { return width; }
		}

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
		/// Constructor to cut shape from another (Copy's constructor).
		/// </summary>
		/// <param name="currentShape">Shape's blank.</param>
		/// <param name="cuttingShape">Cut out shape.</param>
		public BaseRectangleShape(BaseShape currentShape, BaseRectangleShape cuttingShape) : base(currentShape, cuttingShape)
		{
			ShapesUserException.AreaCutting(currentShape, cuttingShape);
			Length = cuttingShape.Length;
			Width = cuttingShape.Width;
		}

		/// <summary>
		/// Method calculate shape's area.
		/// </summary>
		/// <returns>Return shape's perimetr.</returns>
		private double CalculateArea()
		{
			return Length * Width;
		}

		/// <summary>
		/// Method calculate shape's perimeter.
		/// </summary>
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
