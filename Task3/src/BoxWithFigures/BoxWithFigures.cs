using System;
using System.Linq;
using Shapes.Model.Lib;
using System.Collections.Generic;
using Figures.Model.Lib.Interfaces;

namespace BoxWithFiguresLibrary
{
	/// <summary>
	/// Box with figures class. 
	/// </summary>
	public class BoxWithFigures
    {
		/// <summary>
		/// Box size.
		/// </summary>
		public const int BoxSizeIsTwenty = 20;

		/// <summary>
		/// List of abstract figures
		/// </summary>
		public BaseShape[] BoxFigures { get; private set; }

		/// <summary>
		/// Constructor with parameter
		/// </summary>
		/// <param name="figures"></param>
		public BoxWithFigures()
		{
			BoxFigures = new BaseShape[BoxSizeIsTwenty];
		}

		/// <summary>
		/// Method for adding figures to box
		/// </summary>
		/// <param name="figure"></param>
		public void AddFigure(BaseShape figure)
		{
			if (figure ==null)
				throw new ArgumentNullException("Shape is null");

			if (BoxFigures.Contains(figure))
				throw new Exception("Figure of this type are already in the box");

			if (BoxFigures.Count()== BoxSizeIsTwenty)
				throw new Exception("There is no free space in the box");

			var boxShapeIsFull = true;
			for (int i = 0; i < BoxFigures.Length; i++)
			{
				if (BoxFigures[i] == null)
				{
					BoxFigures[i] = figure;
					boxShapeIsFull = false;
					break;
				}
			}
			if (boxShapeIsFull)
				throw new Exception($"The box can't contain more then '{BoxSizeIsTwenty}' shapes.");
		}

		/// <summary>
		/// Method for viewing figures by it's number
		/// </summary>
		/// <param name="number"></param>
		/// <returns></returns>
		public BaseShape ViewByNumber(int number)
		{
			if (BoxFigures[number] != null && number >= 0 && number < BoxFigures.Count())
				return BoxFigures[number];
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
			BoxFigures[number]=null;
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
			if (number<0)
				throw new Exception("Id can't be less then zero");
			
			if (BoxFigures[number] != null && number >= 0 && number < BoxFigures.Count())
				BoxFigures[number] =figure;
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
			foreach (BaseShape item in BoxFigures)
			{
				if (item.Equals(figure))
					return item;
			}
			return null;
		}

		/// <summary>
		/// Method for find out figures count
		/// </summary>
		/// <returns></returns>
		public int FiguresCount()
		{
			return BoxFigures.Count();
		}

		/// <summary>
		/// Method for summation perimeters of all figures in the box
		/// </summary>
		/// <returns></returns>
		public double SumAllFiguresPerimeters()
		{
			double sum = 0;
			foreach (BaseShape item in BoxFigures)
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
			foreach (BaseShape item in BoxFigures)
			{
				sum += item.Area;
			}
			return sum;
		}

		/// <summary>
		/// Method for getting all circles from box to list
		/// </summary>
		/// <returns></returns>
		public IEnumerable<BaseCircleShape> GetAllCircles()
		{
			List<BaseCircleShape> abstractCircles = new List<BaseCircleShape>();
			foreach (BaseCircleShape item in BoxFigures)
			{
				if (item is BaseCircleShape)
				{
					abstractCircles.Add(item);
				}				
			}
			return abstractCircles;
		}

		/// <summary>
		/// Method for getting all film figures from box to list
		/// </summary>
		/// <returns></returns>
		public IEnumerable<BaseShape> GetAllFilmFigures()
		{
			List<BaseShape> abstractFilm = new List<BaseShape>();
			foreach (var item in BoxFigures)
			{
				if (item is IFilm)
				{
					abstractFilm.Add(item);
				}
			}
			return abstractFilm;
		}

		

	}
}
