
namespace Bakery.Model.Products
{
	/// <summary>
	/// Base class of baker's product. 
	/// </summary>
	public abstract class BaseAbstractProduct
	{
		/// <summary>
		/// Empty constructor.
		/// </summary>
		public BaseAbstractProduct()
		{
		}

		/// <summary>
		/// One piece's weight.
		/// </summary>
		public double WeightOnePiece { get; set; }

		/// <summary>
		/// Trade margin property.
		/// </summary>
		public decimal TradeMargin { get; set; }

		/// <summary>
		/// Quantity product property.
		/// </summary>
		public int QuantityProduct { get; set; }

		/// <summary>
		/// Product's total cost.
		/// </summary>
		public abstract decimal TotalCostProduct { get; }

		/// <summary>
		/// Property product's total caloricity.
		/// </summary>
		public abstract double CaloricityOnePiece { get; }

		/// <summary>
		/// Overriden method for get name of class.
		/// </summary>
		/// <returns>Return class name.</returns>
		public override string ToString() => GetType().Name;
	}
}
