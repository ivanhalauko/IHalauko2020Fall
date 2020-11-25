using Bakery.Data.Repositories;
using Bakery.Model.Products;
using NUnit.Framework;
using System.Collections.Generic;

namespace Bakery.DataTests.Repositories
{
	/// <summary>
	/// Test fixture to testing class TxtBakeryData.
	/// </summary>
	[TestFixture()]
	public class TxtBakeryDataTests
	{
		private string _pathToTxtFilecCorrectProduct = @"fileData\ProductsList.txt";
		private string _pathToTxtFilecDifferentText = @"fileData\DifferentList.txt";

		/// <summary>
		/// Test case to testing GetProductArray method. 
		/// </summary>
		[TestCase()]
		public void GivenGetProductArray_WhenInputIsThreeDifferentProduts_ThenOutIsEqual()
		{
			//Arrange
			List<BaseAbstractProduct> expectedProducts = new List<BaseAbstractProduct> { new Bread(3, 1.3m), new Bread(2, 1.4m), new Bread(1, 2.5m)};
			//Act
			IEnumerable<BaseAbstractProduct> actualProducts = new TxtBakeryData(_pathToTxtFilecCorrectProduct).GetProductArray();
			//Assert
			Assert.AreEqual(expectedProducts,actualProducts);
		}

		/// <summary>
		/// Test case to testing GetProductArray method. 
		/// </summary>
		[TestCase()]
		public void GivenGetProductArray_WhenInputIsThreeDifferentProduts_ThenOutAreNotEqual()
		{
			//Arrange
			List<BaseAbstractProduct> expectedProducts = new List<BaseAbstractProduct> { new Bread(3, 1.3m), new Bread(2, 1.4m), new Bread(1, 2.5m) };
			//Act
			IEnumerable<BaseAbstractProduct> actualProducts = new TxtBakeryData(_pathToTxtFilecDifferentText).GetProductArray();
			//Assert
			Assert.AreNotEqual(expectedProducts, actualProducts);
		}
	}
}