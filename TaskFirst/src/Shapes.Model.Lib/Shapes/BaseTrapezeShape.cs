using System;

namespace Shapes.Model.Lib.Shapes
{
	/// <summary>
	/// Class for Trapeze's Shapes.
	/// </summary>
	public class BaseTrapezeShape : BaseShape
	{
		/// <summary>
		/// Property LargeBase Trapeze.
		/// </summary>
		public double LargeBase { get; }

		/// <summary>
		/// Property SmallBase Trapeze.
		/// </summary>
		public double SmallBase { get; }

		/// <summary>
		/// Property Left Side Bit Trapeze.
		/// </summary>
		public double LeftSideBit { get; }

		/// <summary>
		/// Property Right Side Bit Trapeze.
		/// </summary>
		public double RightSideBit { get; }

		/// <summary>
		/// Property rectangle's area.
		/// </summary>
		public override double Area
		{
			get { return CalculateArea(); }
		}

		/// <summary>
		/// Property Trapeze's perimeter.
		/// </summary>
		public override double Perimeter
		{
			get { return CalculatePerimeter(); }
		}

		/// <summary>
		/// Constructor initialized Trapeze object with largeBase, smallBase parametr, leftSideBit and rightSideBit.
		/// </summary>
		/// <param name="largeBase">Large base of trapeze.</param>
		/// <param name="smallBase">Small base of trapeze.</param>
		/// <param name="leftSideBit">Left Side Bit of trapeze.</param>
		/// <param name="rightSideBit">Right Side Bit of trapeze.</param>
		public BaseTrapezeShape(double largeBase, double smallBase, double leftSideBit, double rightSideBit)
		{
			LargeBase = Math.Abs(largeBase);
			SmallBase = Math.Abs(smallBase);
			LeftSideBit = Math.Abs(leftSideBit);
			RightSideBit = Math.Abs(rightSideBit);
		}

		/// <summary>
		/// Method calculate shape's area.
		/// </summary>
		/// <param name="length">Shape's lenght.</param>
		/// <param name="width">Shape's width.</param>
		/// <returns>Return shape's perimetr.</returns>
		private double CalculateArea()
		{
			if (SmallBase != 0 && LargeBase != 0 && LeftSideBit != 0 && RightSideBit != 0 && LeftSideBit == RightSideBit)
			{
				double area = ((SmallBase + LargeBase) / 2) *
								(Math.Sqrt(
											Math.Pow(LeftSideBit, 2) -
											(((Math.Pow(LargeBase - SmallBase, 2)) + (Math.Pow(LeftSideBit, 2) - Math.Pow(RightSideBit, 2))) /
											(2 * (LargeBase - SmallBase)))));
				return area;
			}
			else
			{
				throw new Exception("Trapeze's sides have null value.");
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
			if (SmallBase != 0 && LargeBase != 0 && LeftSideBit != 0 && RightSideBit != 0)
			{
				double perimetr = SmallBase + LargeBase + LeftSideBit + RightSideBit;
				return perimetr;
			}
			else
			{
				throw new Exception("Trapeze's sides is not null value.");
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
			BaseTrapezeShape r = (BaseTrapezeShape)obj;
			return LargeBase.Equals(r.LargeBase) &&
					SmallBase.Equals(r.SmallBase) &&
					LeftSideBit.Equals(r.LeftSideBit) &&
					RightSideBit.Equals(r.RightSideBit);
		}

		/// <summary>
		/// Calculate hash code for comparison one figure with another.
		/// </summary>
		/// <returns>Hash code.</returns>
		public override int GetHashCode()
		{
			return Tuple.Create(LargeBase, base.GetHashCode()).GetHashCode();
		}

		/// <summary>
		/// Conversion class members in string format.
		/// </summary>
		/// <returns>Return members in string format.</returns>
		public override string ToString()
		{
			return string.Format("{0};{1};{2};{3};{4}", base.ToString(), LargeBase, SmallBase, LeftSideBit, RightSideBit);
		}
	}
}
