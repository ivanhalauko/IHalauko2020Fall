namespace Bakery.Model.Ingredients
{
	/// <summary>
	/// Abstract BaseAbstractIngredient class.
	/// </summary>
	public abstract class BaseAbstractIngredient
	{
		/// <summary>
		/// Property cost ingredient.
		/// </summary>
		public decimal Cost { get; set; }

		/// <summary>
		/// Property energy value ingredient.
		/// </summary>
		public int EnergyValue { get; set; }

		/// <summary>
		/// Property weight ingredient.
		/// </summary>
		public double Weight { get; set; }
	}
}
