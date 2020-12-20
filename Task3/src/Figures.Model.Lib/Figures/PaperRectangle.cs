using Figures.Model.Lib.Interfaces;
using Shapes.Model.Lib;
using System;

namespace Figures.Model.Lib.Figures
{
	/// <summary>
	/// Paper rectangle figeres class.
	/// </summary>
	public class PaperRectangle : BaseCircleShape, IPaper, IColor
	{
		/// <summary>
		/// Field of ColorEnum type, figure's color.
		/// </summary>
		private IColor _color;

		/// <summary>
		/// Property shows painted figure or not.  
		/// </summary>
		public bool IsFigurePainted { get; private set; }

		/// <summary>
		/// Constructor with two parameters.
		/// </summary>
		/// <param name="radius">Radius parameter.</param>
		/// <param name="colorEnum">Color parameter.</param>
		public PaperRectangle(double radius, IColor colorEnum) : base(radius)
		{
			_color = colorEnum;
		}

		/// <summary>
		/// Copy constructor to cut shape from another.
		/// </summary>
		/// <param name="currentShape">Shape's blank.</param>
		/// <param name="cuttingShape">Shape which Cut out.</param>
		public PaperRectangle(BaseShape currentShape, PaperRectangle cuttingShape) : base(currentShape, cuttingShape)
		{
		}

		/// <summary>
		/// Color of paper circle
		/// </summary>
		public IColor Color
		{
			get
			{
				return _color;
			}
			set
			{
				if (IsFigurePainted)
				{
					throw new UserException("The figure already painted");
				}
				else
				{
					_color = value;
					IsFigurePainted = true;
				}
			}
		}

		/// <summary>
		/// Comparing one circle wit another.
		/// </summary>
		/// <param name="obj">The compared circle.</param>
		/// <returns>True if equal. False if not eqal.</returns>
		public override bool Equals(Object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			PaperCircle r = (PaperCircle)obj;
			return Color.Equals(r.Color) && base.Equals((BaseRectangleShape)obj);
		}

		/// <summary>
		/// Calculate hash code.
		/// </summary>
		/// <returns>The total hesh code.</returns>
		public override int GetHashCode()
		{
			return Tuple.Create(Color, base.GetHashCode()).GetHashCode();
		}

		/// <summary>
		/// Represents class members in string format.
		/// </summary>
		/// <returns>Returns class members in string format.</returns>
		public override string ToString()
		{
			return string.Format("{0};{1}", base.ToString(), Color);
		}
	}
}
