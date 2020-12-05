﻿using System;
using Products.Domain.Interfaces;

namespace Products.Domain.Model
{
	/// <summary>
	/// Base class BaseProduct.
	/// </summary>
	[Serializable]
	public class BaseProduct : IProduct
	{
		/// <summary>
		/// Cost field.
		/// </summary>
		private decimal cost;

		/// <summary>
		/// Markup field.
		/// </summary>
		private double markup;

		/// <summary>
		/// Quantity field.
		/// </summary>
		private int quantity;

		/// <summary>
		/// Name field.
		/// </summary>
		private string name;

		/// <summary>
		/// Name property.
		/// </summary>
		public string Name
		{
			set { name = value; }
			get { return name; }
		}

		/// <summary>
		/// Property cost from supplier.
		/// </summary>
		public decimal Cost
		{
			set
			{cost = value;	}
			get { return cost; }
		}

		/// <summary>
		///  Property store's markup.
		/// </summary>
		public double Markup
		{
			private set
			{markup = value;	}
			get { return markup; }
		}

		/// <summary>
		/// Property good's quantity.
		/// </summary>
		public int Quantity
		{
			private set { quantity = value; }
			get { return quantity; }
		}

		/// <summary>
		/// Product type property.
		/// </summary>
		public string ProductType { get; }

		/// <summary>
		/// Constructor with name, cost, markup, quantity and productType parameters.
		/// </summary>
		/// <param name="name">Name of book.</param>
		/// <param name="cost">Cost of book from suppliers.</param>
		/// <param name="markup">Product's margin.</param>
		/// <param name="quantity">Product's quantity.</param>
		/// <param name="productType">Product's type.</param>
		public BaseProduct(string name, decimal cost, double markup, int quantity, string productType)
		{
			Name = name;
			Cost = cost;
			Markup = markup;
			Quantity = quantity;
			ProductType = productType;
		}

		/// <summary>
		/// Comparison of the properties of products.
		/// </summary>
		/// <param name="obj">Object.</param>
		/// <returns>Returns bool after comparison.</returns>
		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			BaseProduct v = (BaseProduct)obj;
			return Name.Equals(v.Name) &&
				   Cost.Equals(v.Cost) &&
				   Markup.Equals(v.Markup) &&
				   Quantity.Equals(v.Quantity) &&
				   ProductType.Equals(v.ProductType);
		}

		/// <summary>
		/// Calculate hash code.
		/// </summary>
		/// <returns>The total hesh code.</returns>
		public override int GetHashCode() => Tuple.Create(Name, Cost, Markup, Quantity, ProductType).GetHashCode();

		/// <summary>
		/// Represents class members in string format.
		/// </summary>
		/// <returns>Returns class members in string format.</returns>
		public override string ToString() => string.Format("{0}", GetType().Name);

	}
}
