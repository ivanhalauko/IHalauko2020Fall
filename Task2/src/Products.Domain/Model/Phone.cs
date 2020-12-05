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
	}
}
