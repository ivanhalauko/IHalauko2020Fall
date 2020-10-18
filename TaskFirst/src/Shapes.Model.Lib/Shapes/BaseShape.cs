using System;

namespace Shapes.Model.Lib.Shapes
{
	/// <summary>
	/// Abstract class base shapes.
	/// </summary>
	public abstract class BaseShape : IBaseShape
	{
		/// <summary>
		/// Property figure's area 
		/// </summary>
		public abstract double Area { get; }

		/// <summary>
		/// Property figure's perimetr
		/// </summary>
		public abstract double Perimeter { get; }

		/// <summary>
		/// Empty costructor.
		/// </summary>
		public BaseShape()
		{
		}
		/// <summary>
		/// Comparring the properties of two base shapes. Override Equals method for work with two base shapes.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns>Return "true" or "false" after comparer.</returns>
		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			BaseShape shape = (BaseShape)obj;
			return Area.Equals(shape.Area) && Perimeter.Equals(shape.Perimeter);
		}

		/// <summary>
		/// Hash calculation
		/// </summary>
		/// <returns>Return hash code.</returns>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>
		/// Override base method ToString for get name of class.
		/// </summary>
		/// <returns>Return type's name.</returns>
		public override string ToString()
		{
			return GetType().Name;
		}
	}
}
