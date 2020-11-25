using System;
using System.Linq;
using Bakery.Model.Products;
using System.Collections.Generic;
using Bakery.Service.Interfaces;

namespace Bakery.Service.Repository
{
	/// <summary>
	/// BakeryServiceRepository class.
	/// </summary>
	public class BakeryServiceRepository : IBakeryService
	{
		/// <summary>
		/// Property with BakeryProducts array.
		/// </summary>
		public BaseAbstractProduct[] ArrayBakeryProducts;

		/// <summary>
		/// Constructor for init BakeryServiceRepository array.
		/// </summary>
		/// <param name="countOfArray">CountOfArray parameter.</param>
		public BakeryServiceRepository(int countOfArray)
		{
			ArrayBakeryProducts = new BaseAbstractProduct[countOfArray];
		}

		/// <summary>
		/// Products array OrderByCaloricity.
		/// </summary>
		/// <param name="ArrayBakeryProducts">Array bakery products.</param>
		/// <returns>Array bakery products ordered by caloricity.</returns>
		public BaseAbstractProduct OrderByCaloricity(BaseAbstractProduct[] ArrayBakeryProducts)
		{
			var orderByCaloricity = from i in ArrayBakeryProducts
									orderby i.CaloricityOnePiece
									select i;

			return (BaseAbstractProduct)orderByCaloricity;
		}

		/// <summary>
		/// Products array OrderByCost.
		/// </summary>
		/// <param name="ArrayBakeryProducts">Array bakery products.</param>
		/// <returns>Array bakery products ordered by Cost.</returns>
		public BaseAbstractProduct OrderByCost(BaseAbstractProduct[] ArrayBakeryProducts)
		{
			var orderByCost = from i in ArrayBakeryProducts
							  orderby i.TotalCostProduct
							  select i;

			return (BaseAbstractProduct)orderByCost;
		}

		/// <summary>
		/// Find product by propertes method.
		/// </summary>
		/// <param name="costProduct">CostProduct parameter.</param>
		/// <param name="caloricity">Caloricity parameter.</param>
		/// <returns>Products.</returns>
		public BaseAbstractProduct FindProductByPropertes(decimal costProduct, double caloricity)
		{
			var orderByCostAndcaloricity = from i in ArrayBakeryProducts
										   where i.TotalCostProduct == costProduct && i.CaloricityOnePiece == caloricity
										   select i;

			return (BaseAbstractProduct)orderByCostAndcaloricity;
		}

		///// <summary>
		///// Find products by weight.
		///// </summary>
		///// <param name="costProduct">CostProduct parameter.</param>
		///// <param name="caloricity">Caloricity parameter.</param>
		///// <returns>Product.</returns>
		//public BaseAbstractProduct FindProductsByIngridientWeight(string typeIngridient, double weightIngridient)
		//{

		//	var orderByIngridientWeight = from i in ArrayBakeryProducts
		//								  where i.
		//								   select i;

		//	return (BaseAbstractProduct)orderByCostAndcaloricity;
		//}

		///// <summary>
		///// Find products by IngredientsCounts.
		///// </summary>
		///// <param name="countIngredients">CountIngredients parameter.</param>
		///// <returns>Product.</returns>
		//public BaseAbstractProduct FindProductsByIngredientsCountsMore(int countIngredients)
		//{
		//	BaseAbstractProduct[] Products = ;

		//	int size = (from i in ArrayBakeryProducts where i. > countIngredients select i).Count();

		//	return BaseAbstractProduct;
		//}


	}
}
