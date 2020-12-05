using System;

namespace Products.Domain.Model
{
	/// <summary>
	/// Class book product.
	/// </summary>
	[Serializable]
	public class Book : BaseProduct
	{
		/// <summary>
		/// Constructor with name, cost, markup, quantity and productType parameters.
		/// </summary>
		/// <param name="name">Name of book.</param>
		/// <param name="cost">Cost of book from suppliers.</param>
		/// <param name="markup">Product's margin.</param>
		/// <param name="quantity">Product's quantity.</param>
		/// <param name="productType">Product's type.</param>
		public Book(string name, decimal cost, double markup, int quantity, string productType) : base(name, cost, markup, quantity, productType)
		{
		}

		
		/// <summary>
		/// Override Equals method for comparing one book with another..
		/// </summary>
		/// <param name="obj">Object parameter.</param>
		/// <returns>Return bool value.</returns>
		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			return obj is Book book &&
			   base.Equals(obj) &&
			   Name == book.Name &&
			   Cost == book.Cost &&
			   Markup == book.Markup &&
			   Quantity == book.Quantity &&
			   ProductType == book.ProductType;
			 
		}

		/// <summary>
		/// Override GetHashCode method.
		/// </summary>
		/// <returns>Return hash code.</returns>
		public override int GetHashCode() => Tuple.Create(base.GetHashCode()).GetHashCode();

		/// <summary>
		/// Override ToString method.
		/// </summary>
		/// <returns>Return string</returns>
		public override string ToString() => string.Format("{0};{1};{2};{3};{4}",
			base.ToString(), Name, Cost, Markup, Quantity, ProductType);
	}
}
