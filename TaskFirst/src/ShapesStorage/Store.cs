using Shapes.Model.Lib.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapesStorage
{
    public class Store
    {
		/// <summary>
		/// List of abstract figures.
		/// </summary>
		public List<BaseShape> Figures { get; set; }

		/// <summary>
		/// Constructor with parameter.
		/// </summary>
		/// <param name="figures"></param>
		public Store(List<BaseShape> figures)
		{
			Figures = figures;
		}

		/// <summary>
		/// Constructor without parameters.
		/// </summary>
		public Store() : this(new List<BaseShape>())
		{
		}

		/// <summary>
		/// Method for adding figures to list.
		/// </summary>
		/// <param name="figure"></param>
		public void AddShape(BaseShape figure)
		{
			if (Figures.Contains(figure))
				throw new Exception("Figure of this type are already in the store");

			if (Figures.Count == 20)
				throw new Exception("There is no free space in the store");

			Figures.Add(figure);
		}

		/// <summary>
		/// Method for summation perimeters of all figures in the list.
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
		/// Method for summation areas of all figures in the list.
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
		/// Method for calculation Average perimeters of all figures in the list.
		/// </summary>
		/// <returns></returns>
		public double AverageAllFiguresPerimeters()
		{
			var countOfList = Figures.Count();
			double sum = 0;
			foreach (BaseShape item in Figures)
			{
				sum += item.Perimeter;
			}
			return sum / countOfList;
		}

		/// <summary>
		/// Method for calculation Average areas of all figures in the list.
		/// </summary>
		/// <returns></returns>
		public double AverageAllFiguresAreas()
		{
			var countOfList = Figures.Count();
			double sum = 0;
			foreach (BaseShape item in Figures)
			{
				sum += item.Area;
			}
			return sum / countOfList;
		}

		/// <summary>
		/// Method for find lager area of all figures in the list.
		/// </summary>
		/// <returns></returns>
		public double GetLargerAreaFromFigures()
		{
			int lengthFiguresList = Figures.Count;
			int i = 0;
			double[] tempValue = new double[lengthFiguresList];

			double valueArea = 0;

			foreach (BaseShape item in Figures)
			{
				valueArea = item.Area;
				tempValue[i] = valueArea;
				i++;
			}
			for (int k = 0; k < tempValue.Length - 1 && (k + 1) <= tempValue.Length; k++)
			{
				if (tempValue[k] < tempValue[k + 1])
				{
					valueArea = tempValue[k + 1];
				}
				else
				{
					return valueArea;
				}
			}
			return valueArea;
		}

		// <summary>
		/// Comparison one list with another.
		/// </summary>
		/// <param name="obj">Comparer parameter.</param>
		/// <returns>Return "true" if equal and "false" if not equal.</returns>
		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			Store r = (Store)obj;
			return //Figures.Contains(r.Figures); 
				   //Figures.Equals(r.Figures);
				Enumerable.SequenceEqual(Figures, r.Figures);
		}

		/// <summary>
		/// Calculate hash code for comparison one list with another.
		/// </summary>
		/// <returns>Hash code.</returns>
		public override int GetHashCode()
		{
			return Tuple.Create(Figures).GetHashCode();
		}
	}
}
