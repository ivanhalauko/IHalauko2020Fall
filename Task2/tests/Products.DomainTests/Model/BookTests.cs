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
	}
}