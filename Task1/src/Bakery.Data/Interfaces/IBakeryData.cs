using Bakery.Model.Products;

namespace Bakery.Data.Interfaces
{
	/// <summary>
	/// IBakeryData interface.
	/// </summary>
	interface IBakeryData
	{
		/// <summary>
		/// Get base abstract product array with product.
		/// </summary>
		/// <returns></returns>
		BaseAbstractProduct[] GetProductArray();
	}
}
