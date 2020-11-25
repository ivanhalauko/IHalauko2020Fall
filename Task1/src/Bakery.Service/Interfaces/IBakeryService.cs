using Bakery.Model.Products;
using System.Collections.Generic;

namespace Bakery.Service.Interfaces
{
	/// <summary>
	/// Interface IBakeryService.
	/// </summary>
	public interface IBakeryService//<T>
	{
		/// <summary>
		/// Products array OrderByCaloricity.
		/// </summary>
		/// <param name="ArrayBakeryProducts">Array bakery products.</param>
		/// <returns>Array bakery products ordered by caloricity.</returns>
		BaseAbstractProduct OrderByCaloricity(BaseAbstractProduct[] ArrayBakeryProducts);

		/// <summary>
		/// Products array OrderByCost.
		/// </summary>
		/// <param name="ArrayBakeryProducts">Array bakery products.</param>
		/// <returns>Array bakery products ordered by Cost.</returns>
		BaseAbstractProduct OrderByCost(BaseAbstractProduct[] ArrayBakeryProducts);

		/// <summary>
		/// Find product by propertes method.
		/// </summary>
		/// <param name="costProduct">CostProduct parameter.</param>
		/// <param name="caloricity">Caloricity parameter.</param>
		/// <returns>Products.</returns>
		BaseAbstractProduct FindProductByPropertes(decimal costProduct, double caloricity);

		/// <summary>
		/// Find products by weight.
		/// </summary>
		/// <param name="costProduct">CostProduct parameter.</param>
		/// <param name="caloricity">Caloricity parameter.</param>
		/// <returns>Product.</returns>
		BaseAbstractProduct FindProductsByWeight(decimal costProduct, double caloricity);

		/// <summary>
		/// Find products by IngredientsCounts.
		/// </summary>
		/// <param name="countIngredients">CountIngredients parameter.</param>
		/// <returns>Product.</returns>
		BaseAbstractProduct FindProductsByIngredientsCountsMore(int countIngredients);

	}
}
