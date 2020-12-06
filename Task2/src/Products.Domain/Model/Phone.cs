using Products.Domain.UserExceptions;
using System;

namespace Products.Domain.Model
{
	/// <summary>
	/// Phone product class.
	/// </summary>
	[Serializable]
	public class Phone : BaseProduct
	{
		/// <summary>
		/// Constructor with name, cost, markup, quantity and productType parameters.
		/// </summary>
		/// <param name="name">Name of book.</param>
		/// <param name="cost">Cost of book from suppliers.</param>
		/// <param name="markup">Product's margin.</param>
		/// <param name="quantity">Product's quantity.</param>
		/// <param name="productType">Product's type.</param>
		public Phone(string name, decimal cost, double markup, int quantity, string productType) : base(name, cost, markup, quantity, productType)
		{
		}

		/// <summary>
		/// The method overrides the mathematical "plus" operation for working with Products objects by cost, markup and quantity. Task's point №8.
		/// </summary>
		/// <param name="firstProduct">First product summand.</param>
		/// <param name="secondProduct">Second product summand.</param>
		/// <returns>New product result.</returns>
		public static Phone operator +(Phone firstProduct, Phone secondProduct)
		{
			if (firstProduct == null)
				throw new ArgumentNullException("Fist Phone is null");
			if (secondProduct == null)
				throw new ArgumentNullException("Second Phone two is null");
			if (firstProduct.Name != secondProduct.Name)
				throw new ArgumentException("Fist Phone's name is not equal second Phone's name.");
			if (firstProduct.ProductType != secondProduct.ProductType)
				throw new ArgumentException("Fist Phone's Type is not equal second Phone's Type.");

			return new Phone(
				name: firstProduct.Name,
				cost: Math.Round((firstProduct.Cost * firstProduct.Quantity + secondProduct.Cost * secondProduct.Quantity) / (firstProduct.Quantity + secondProduct.Quantity), 3, MidpointRounding.AwayFromZero),
				markup: Math.Round((firstProduct.Markup * firstProduct.Quantity + secondProduct.Markup * secondProduct.Quantity) / (firstProduct.Quantity + secondProduct.Quantity), 3, MidpointRounding.AwayFromZero),
				quantity: firstProduct.Quantity + secondProduct.Quantity,
				productType: firstProduct.ProductType
				);
		}

		/// <summary>
		/// The method overrides the mathematical "minus" operation for working with Products objects. Task's point №9.
		/// </summary>
		/// <param name="product">Product parameter.</param>
		/// <param name="productsNumber">Number parameter.</param>
		/// <returns>New product with new quantity result.</returns>
		public static Phone operator -(Phone product, int productsNumber)
		{
			if (productsNumber < 0)
				ProductExceptions.SetIncorrectIntValue(productsNumber);
			if (product == null)
				throw new ArgumentNullException("Product is not null");

			return new Phone(
				name: product.Name,
				cost: product.Cost,
				markup: product.Markup,
				quantity: product.Quantity - productsNumber,
				productType: product.ProductType
				);
		}

		/// <summary>
		/// Convet Phone type to book. Task's point №10.
		/// </summary>
		/// <param name="product">Return book type.</param>
		public static explicit operator Phone(Book product) => new Phone(product.Name, product.Cost, product.Markup, product.Quantity, product.ProductType);

		/// <summary>
		/// Override Equals method for comparing one book with another..
		/// </summary>
		/// <param name="obj">Object parameter.</param>
		/// <returns>Return bool value.</returns>
		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			return obj is Phone phone &&
			   base.Equals(obj) &&
			   Name == phone.Name &&
			   Cost == phone.Cost &&
			   Markup == phone.Markup &&
			   Quantity == phone.Quantity &&
			   ProductType == phone.ProductType &&
			   Price == phone.Price &&
			   TotalPrice == phone.TotalPrice;
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
