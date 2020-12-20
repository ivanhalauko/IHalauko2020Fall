using System;
using Shapes.Model.Lib;
using System.Collections.Generic;

namespace BoxWithFiguresLibrary
{
    public class BoxWithFigures
    {
		/// <summary>
		/// List of abstract figures
		/// </summary>
		public List<BaseShape> Figures { get; private set; }

		/// <summary>
		/// Constructor with parameter
		/// </summary>
		/// <param name="figures"></param>
		public BoxWithFigures(List<BaseShape> figures)
		{
			Figures = figures;
		}

		/// <summary>
		/// Constructor without parameters
		/// </summary>
		public BoxWithFigures() : this(new List<BaseShape>())
		{
		}

		/// <summary>
		/// Method for adding figures to box
		/// </summary>
		/// <param name="figure"></param>
		public void AddFigure(BaseShape figure)
		{
			if (Figures.Contains(figure))
				throw new Exception("Figure of this type are already in the box");

			if (Figures.Count == 20)
				throw new Exception("There is no free space in the box");

			Figures.Add(figure);
		}

		/// <summary>
		/// Method for viewing figures by it's number
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public BaseShape ViewByNumber(int number)
		{
			if (Figures[number] != null && number >= 0 && number < Figures.Count)
				return Figures[number];
			else
				throw new Exception("Figure with such number does not exist");
		}

		/// <summary>
		/// Method for extracting figures from box by it's number
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public BaseShape ExtractByNumber(int number)
		{
			BaseShape figure = ViewByNumber(number);

			Figures.RemoveAt(number);

			return figure;
		}

		/// <summary>
		/// Method for replacing figure by it's number on another figure
		/// </summary>
		/// <param name="number"></param>
		/// <param name="figure"></param>
		public void ReplaceByNumberOnFigure(int number, BaseShape figure)
		{
			if (figure == null)
				throw new Exception("The figure does not exist");

			if (Figures[number] != null && number >= 0 && number < Figures.Count)
			{
				Figures.RemoveAt(number);
				Figures.Insert(number, figure);
			}
			else
				throw new Exception("Figure with such number does not exist");
		}

		/// <summary>
		/// Method for finding equivalent figure in the box
		/// </summary>
		/// <param name="figure"></param>
		/// <returns></returns>
		public BaseShape FindEquivalentFigure(BaseShape figure)
		{
			foreach (BaseShape item in Figures)
			{
				if (item.Equals(figure))
				{
					return item;
				}
			}

			return null;
		}

		/// <summary>
		/// Method for find out figures count
		/// </summary>
		/// <returns></returns>
		public int FiguresCount()
		{
			return Figures.Count;
		}

		/// <summary>
		/// Method for summation perimeters of all figures in the box
		/// </summary>
		/// <returns></returns>
		public double SumAllFiguresPerimeters()
		{
			double sum = 0;
			foreach (BaseShape item in Figures)
			{
				sum += item.Perimeter;
			}

			return sum;
		}

		/// <summary>
		/// Method for summation areas of all figures in the box
		/// </summary>
		/// <returns></returns>
		public double SumAllFiguresAreas()
		{
			double sum = 0;
			foreach (BaseShape item in Figures)
			{
				sum += item.Area;
			}

			return sum;
		}

		/// <summary>
		/// Method for getting all circles from box to list
		/// </summary>
		/// <returns></returns>
		public List<BaseCircleShape> GetAllCircles()
		{
			List<BaseCircleShape> abstractCircles = new List<BaseCircleShape>();
			foreach (BaseCircleShape item in Figures)
			{
				abstractCircles.Add(item);
			}

			return abstractCircles;
		}
	}
}
