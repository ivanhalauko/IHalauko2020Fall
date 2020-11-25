using Bakery.Model.Products;
using NUnit.Framework;

namespace Bakery.ModelTests
{
	/// <summary>
	/// Test cases to testing class Bread.
	/// </summary>
	[TestFixture()]
	public class BreadTests
	{
		[TestCase(400, 2, 1.3, 584)]
		[TestCase(1000,1,1,1460)]
		public void GivenCost_WhenWeightOnePieceIsPositive_ThenOutIsPositiveCost(double weightOnePiece, int quantityProduct, decimal tradeMargin, decimal expectedResult)
		{
			//Arrange
			Bread bread = new Bread(weightOnePiece, quantityProduct, tradeMargin);
			//Act
			var actualResult = bread.Cost;
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestCase(400, 2, 1.3, 759.2)]
		[TestCase(1000, 1, 1, 1460)]
		public void GivenCost_WhenWeightOnePieceIsPositive_ThenOutIsPositiveTotalCost(double weightOnePiece, int quantityProduct, decimal tradeMargin, decimal expectedResult)
		{
			//Arrange
			Bread bread = new Bread(weightOnePiece, quantityProduct, tradeMargin);
			//Act
			var actualResult = bread.TotalCostProduct;
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestCase(400, 2, 1.3, 4704)]
		[TestCase(1000, 1, 1, 11760)]
		public void GivenCost_WhenWeightOnePieceIsPositive_ThenOutIsPositiveCaloricityOnePiece(double weightOnePiece, int quantityProduct, decimal tradeMargin, decimal expectedResult)
		{
			//Arrange
			Bread bread = new Bread(weightOnePiece, quantityProduct, tradeMargin);
			//Act
			var actualResult = bread.CaloricityOnePiece;
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}
