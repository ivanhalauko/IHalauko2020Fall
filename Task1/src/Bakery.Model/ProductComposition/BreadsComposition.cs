using Bakery.Model.Ingredients;

namespace Bakery.Model.ProductComposition
{
	/// <summary>
	/// Product's BreadsComposition class.
	/// </summary>
	public class BreadsComposition : IProductComposition
	{
		/// <summary>
		/// Product's butter property.
		/// </summary>
		public Butter Butter { get; set; }
		/// <summary>
		/// Product's flour property.
		/// </summary>
		public Flour Flour { get; set; }
		/// <summary>
		/// Product's WeightOnePiece property.
		/// </summary>
		public double WeightOnePiece { get; set; }

		/// <summary>
		/// Product's BreadsComposition constructor with parameters.
		/// </summary>
		/// <param name="weightOnePiece">Product's weightOnePiece parameter.</param>
		public BreadsComposition(double weightOnePiece)
		{
			Butter = new Butter(weightOnePiece * 0.3);
			Flour = new Flour(weightOnePiece * 0.7);
		}

		/// <summary>
		/// Product's GetCaloricityOnePeace method with parameters.
		/// </summary>
		/// <param name="weightOnePiece">Product's weightOnePiece parameter.</param>
		/// <returns>CaloricityOnePeace.</returns>
		public double GetCaloricityOnePeace(double weightOnePiece)
		{
			double totalCaloricityButter = Butter.EnergyValue * (Butter.Weight / 100);
			double totalCaloricityFlour = Flour.EnergyValue * (Flour.Weight / 100);
			return totalCaloricityButter + totalCaloricityFlour;
		}
		/// <summary>
		/// Product's GetCostOnePeace method with parameters.
		/// </summary>
		/// <param name="weightOnePiece">Product's weightOnePiece parameter.</param>
		/// <returns>CostOnePeace.</returns>
		public decimal GetCostOnePeace(double weightOnePiece)
		{
			decimal totalCostButter = Butter.Cost * ((decimal)Butter.Weight / 100);
			decimal totalCostFlour = Flour.Cost * ((decimal)Flour.Weight / 100);
			return totalCostButter + totalCostFlour;
		}
	}
}
