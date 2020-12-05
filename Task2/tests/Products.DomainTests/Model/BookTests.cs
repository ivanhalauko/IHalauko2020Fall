using NUnit.Framework;

namespace Products.Domain.Model.Tests
{
	[TestFixture()]
	public class BookTests
	{
		[TestCase("ProductOne", 10, 1.5, 2, "Product", 15)]
		[TestCase("ProductTwo", 20, 1.6, 5, "Product", 32)]
		[TestCase("ProductThree", 30, 1.7, 6, "Product", 51)]
		public void GivenGetPrice_WhenClassesFieldsIsPositive_ThenOutIsPriceProduct(
			string productOneName, decimal productOneCost, double productOneMarkup, int productOneQuantity, string productOneProductType,
			decimal expectedProductsPrice)
		{
			//Arrange
			Book productOne = new Book(productOneName, productOneCost, productOneMarkup, productOneQuantity, productOneProductType);
			//Act
			decimal actualProductsPrice = productOne.Price;
			//Assert
			Assert.AreEqual(expectedProductsPrice, actualProductsPrice);
		}

		[TestCase("ProductOne", 10, 1.5, 2, "Product", 30)]
		[TestCase("ProductTwo", 20, 1.6, 5, "Product", 160)]
		[TestCase("ProductThree", 30, 1.7, 6, "Product", 306)]
		public void GivenGetTotalPrice_WhenClassesFieldsIsPositive_ThenOutIsPriceProduct(
			string productOneName, decimal productOneCost, double productOneMarkup, int productOneQuantity, string productOneProductType,
			decimal expectedProductsPrice)
		{
			//Arrange
			Book productOne = new Book(productOneName, productOneCost, productOneMarkup, productOneQuantity, productOneProductType);
			//Act
			decimal actualProductsTotalPrice = productOne.TotalPrice;
			//Assert
			Assert.AreEqual(expectedProductsPrice, actualProductsTotalPrice);
		}

		[TestCase("ProductOne", 10, 1.5, 2, "Product", "ProductOne", 20, 1.2, 3, "Product", "ProductOne", 16, 1.32, 5, "Product")]
		[TestCase("ProductTwo", 20, 1.6, 5, "Product", "ProductTwo", 30, 1.3, 4, "Product", "ProductTwo", 24.444, 1.467, 9, "Product")]
		[TestCase("ProductThree", 30, 1.7, 6, "Product", "ProductThree", 40, 1.4, 5, "Product", "ProductThree", 34.545, 1.564, 11, "Product")]
		public void GivenOperatorSum_WhenClassesFieldsIsPositive_ThenOutIsPositive(
			string productOneName, decimal productOneCost, double productOneMarkup, int productOneQuantity, string productOneProductType,
			string productTwoName, decimal productTwoCost, double productTwoMarkup, int productTwoQuantity, string productTwoProductType,
			string expectedName, decimal expectedCost, double expectedMarkup, int expectedQuantity, string expectedProductType
			)
		{
			//Arrange
			Book productOne = new Book(productOneName, productOneCost, productOneMarkup, productOneQuantity, productOneProductType);
			Book productTwo = new Book(productTwoName, productTwoCost, productTwoMarkup, productTwoQuantity, productTwoProductType);
			Book expectedProduct = new Book(expectedName, expectedCost, expectedMarkup, expectedQuantity, expectedProductType);
			//Act
			var actualProduct = productOne + productTwo;
			//Assert
			Assert.AreEqual(expectedProduct, actualProduct);
		}
	}
}