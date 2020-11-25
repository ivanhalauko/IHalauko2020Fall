namespace Bakery.Model.Ingredients
{
	/// <summary>
	/// Flour Ingredient class. 
	/// </summary>
	public class Flour : BaseAbstractIngredient
	{
		/// <summary>
		/// Constuctor with parameter.
		/// </summary>
		/// <param name="weight">Ingredient's weight parameter.</param>
		public Flour(double weight)
		{
			base.Weight = weight;
			base.Cost = 200;
			base.EnergyValue = 1380;
		}
	}
}
