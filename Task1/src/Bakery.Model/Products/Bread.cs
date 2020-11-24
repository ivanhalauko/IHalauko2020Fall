using System;

namespace Bakery.Model.Products
{
	/// <summary>
	/// Class bread's products.
	/// </summary>
	public class Bread : BaseAbstractProduct
	{
		/// <summary>
		/// Product's cost.
		/// </summary>
		public decimal Cost { get; }

		/// <summary>
		/// Property product's total caloricity.
		/// </summary>
		public override double CaloricityOnePiece { get; }

		/// <summary>
		/// Product's total cost.
		/// </summary>
		public override decimal TotalCostProduct => Cost * TradeMargin;

		/// <summary>
		/// Constructor with parametres.
		/// </summary>
		/// <param name="quantityProduct">Product's quantity.</param>
		/// <param name="tradeMargin">Trade margin.</param>
		public Bread(int quantityProduct, decimal tradeMargin)
		{
			QuantityProduct = quantityProduct;
			TradeMargin = tradeMargin;
		}

		/// <summary>
		/// Constructor with parametres.
		/// </summary>
		/// <param name="weightOnePiece">One piece's weight.</param>
		/// <param name="quantityProduct">Product's quantity.</param>
		/// <param name="tradeMargin">Trade margin.</param>
		public Bread(double weightOnePiece, int quantityProduct, decimal tradeMargin) : this(quantityProduct, tradeMargin)
		{
			WeightOnePiece = weightOnePiece;
		}

		/// <summary>
		/// Comparing one rectangle with another.
		/// </summary>
		/// <param name = "obj" > The compared rectangle.</param>
		/// <returns>True if equal.False if not equal.</returns>
		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;
			Bread r = (Bread)obj;
			return Cost.Equals(r.Cost) && TradeMargin.Equals(r.TradeMargin);
		}
		/// <summary>
		/// Calculate hash code.
		/// </summary>
		/// <returns>The total hesh code.</returns>
		public override int GetHashCode()
		{
			return Tuple.Create(Cost, TradeMargin).GetHashCode();
		}
	}
}
