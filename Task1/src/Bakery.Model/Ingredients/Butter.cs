namespace Bakery.Model.Ingredients
{
	/// <summary>
	/// Butter Ingredient class. 
	/// </summary>
	public class Butter : BaseAbstractIngredient
	{
		/// <summary>
		/// Constuctor with parameter.
		/// </summary>
		/// <param name="weight">Ingredient's weight parameter.</param>
		public Butter(double weight)
		{
			base.Weight = weight;
			base.Cost = 20;
			base.EnergyValue = 700;

		}
	}
}

