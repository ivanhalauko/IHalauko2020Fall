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
		/// The method overrides the mathematical "plus" operation for working with Products objects by cost, markup and quantity. Task's point №8.
		/// </summary>
		/// <param name="firstProduct">First product summand.</param>
		/// <param name="secondProduct">Second product summand.</param>
		/// <returns>New product result.</returns>
		public static Book operator +(Book firstProduct, Book secondProduct)
		{
			if (firstProduct == null)
				throw new ArgumentNullException("Fist Book is null");
			if (secondProduct == null)
				throw new ArgumentNullException("Second Book two is null");
			if (firstProduct.Name != secondProduct.Name)
				throw new ArgumentException("Fist Book's name is not equal second book's name.");
			if (firstProduct.ProductType != secondProduct.ProductType)
				throw new ArgumentException("Fist Book's Type is not equal second book's Type.");

			return new Book(
				name: firstProduct.Name,
				cost: Math.Round((firstProduct.Cost * firstProduct.Quantity + secondProduct.Cost * secondProduct.Quantity) / (firstProduct.Quantity + secondProduct.Quantity), 3, MidpointRounding.AwayFromZero),
				markup: Math.Round((firstProduct.Markup * firstProduct.Quantity + secondProduct.Markup * secondProduct.Quantity) / (firstProduct.Quantity + secondProduct.Quantity), 3, MidpointRounding.AwayFromZero),
				quantity: firstProduct.Quantity + secondProduct.Quantity,
				productType: firstProduct.ProductType
				);
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
			   ProductType == book.ProductType &&
			   Price == book.Price &&
			   TotalPrice == book.TotalPrice;
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
		public override string ToString() => string.Format("{0};{1};{2};{3};{4};{5};{6}",
			base.ToString(), Name, Cost, Markup, Quantity, ProductType, Price, TotalPrice);
	}
}
