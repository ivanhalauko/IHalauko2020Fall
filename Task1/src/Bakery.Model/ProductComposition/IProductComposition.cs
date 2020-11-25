
namespace Bakery.Model.ProductComposition
{
	/// <summary>
	/// Interface IProductComposition.
	/// </summary>
	public interface IProductComposition
	{
		/// <summary>
		/// Products's property WeightOnePiece.
		/// </summary>
		double WeightOnePiece { get; set; }

		/// <summary>
		/// Products's method GetCaloricityOnePeace.
		/// </summary>
		/// <param name="weightOnePiece">Products's parameter WeightOnePiece.</param>
		/// <returns>Product's CaloricityOnePeace.</returns>
		double GetCaloricityOnePeace(double weightOnePiece);

		/// <summary>
		/// Products's method GetCostOnePeace.
		/// </summary>
		/// <param name="weightOnePiece">Products's parameter WeightOnePiece.</param>
		/// <returns>Product's CostOnePeace.</returns>
		decimal GetCostOnePeace(double weightOnePiece);
	}
}
