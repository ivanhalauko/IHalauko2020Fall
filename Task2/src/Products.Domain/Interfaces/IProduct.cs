namespace Products.Domain.Interfaces
{
	/// <summary>
	/// Interface IProduct.
	/// </summary>
	public interface IProduct
	{
		/// <summary>
		/// Property cost from supplier.
		/// </summary>
		decimal Cost { get; set; }

		/// <summary>
		///  Property store's markup.
		/// </summary>
		double Markup { get; }

		/// <summary>
		/// Name property.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Product's price property. Task's point №6.
		/// </summary>
		decimal Price { get; }

		/// <summary>
		/// Product type property.
		/// </summary>
		string ProductType { get; }

		/// <summary>
		/// Property good's quantity.
		/// </summary>
		int Quantity { get; }

		/// <summary>
		/// Property to get good's prices. Task's point №6.
		/// </summary>
		decimal TotalPrice { get; }

		/// <summary>
		/// Comparison of the properties of products.
		/// </summary>
		/// <param name="obj">Object.</param>
		/// <returns>Returns bool after comparison.</returns>
		bool Equals(object obj);

		/// <summary>
		/// Calculate hash code.
		/// </summary>
		/// <returns>The total hesh code.</returns>
		int GetHashCode();

		/// <summary>
		/// Represents class members in string format.
		/// </summary>
		/// <returns>Returns class members in string format.</returns>
		string ToString();
	}
}
