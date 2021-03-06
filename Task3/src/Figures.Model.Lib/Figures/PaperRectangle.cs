﻿using System;
using Shapes.Model.Lib;
using Figures.Model.Lib.Enums;
using Figures.Model.Lib.Interfaces;
using Figures.Model.Lib.FigUserException;

namespace Figures.Model.Lib.Figures
{
	/// <summary>
	/// Paper rectangle figeres class.
	/// </summary>
	public class PaperRectangle : BaseRectangleShape, IPaper
	{
		/// <summary>
		/// Field of ColorEnum type, figure's color.
		/// </summary>
		private ColorEnum _color;

		///// <summary>
		///// Field figure's colored.
		///// </summary>
		//private bool _isFigurePainted;

		/// <summary>
		/// Property shows painted figure or not.  
		/// </summary>
		public bool IsFigurePainted { get; private set; } = false;

		/// <summary>
		/// Constructor with three parameters.
		/// </summary>
		/// <param name="length">Figures length.</param>
		/// <param name="width">Figure's width.</param>
		/// <param name="colorEnum">Figure's color.</param>
		public PaperRectangle(double length, double width, ColorEnum colorEnum) : base(length,width)
		{
			if (colorEnum != ColorEnum.IsNotColoured)
			{
				_color = colorEnum;
				IsFigurePainted = true;
			}
		}

		/// <summary>
		/// Copy constructor to cut shape from another.
		/// </summary>
		/// <param name="currentShape">Shape's blank.</param>
		/// <param name="cuttingShape">Shape which Cut out.</param>
		public PaperRectangle(BaseShape currentShape, PaperRectangle cuttingShape) : base(currentShape, cuttingShape)
		{
			var coloredCurShape = (IPaper)currentShape;
			var paperPrevShapeColor = coloredCurShape.Color;
			FiguresUserException.ColorEqualsHandler(paperPrevShapeColor, cuttingShape.Color);
			_color = cuttingShape.Color;
		}

		/// <summary>
		/// Color of paper circle
		/// </summary>
		public ColorEnum Color
		{
			get => _color;

			set
			{
				if (IsFigurePainted)
					FiguresUserException.PaintingFigureHandler(this.IsFigurePainted,this.Color);			
				if (IsFigurePainted==false)
				{
					_color = value;
					FiguresUserException.PaintingClearFigureHandler(this.IsFigurePainted, this.Color);
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
			PaperRectangle r = (PaperRectangle)obj;
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
