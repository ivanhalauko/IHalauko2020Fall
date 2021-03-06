﻿using NUnit.Framework;
using Products.Domain.UserExceptions;

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

		[TestCase("ProductOne", 10, 1.5, 3, "Product", 2, "ProductOne", 10, 1.5, 1, "Product")]
		[TestCase("ProductOne", 15, 2, 10, "Product", 2, "ProductOne", 15, 2, 8, "Product")]
		[TestCase("ProductOne", 20, 1, 15, "Product", 2, "ProductOne", 20, 1, 13, "Product")]
		public void GivenOperatorMinus_WhenClassesFieldsIsPositive_ThenOutIsPositive(
			string productOneName, decimal productOneCost, double productOneMarkup, int productOneQuantity, string productOneProductType,
			int productsNumber,
			string expectedName, decimal expectedCost, double expectedMarkup, int expectedQuantity, string expectedProductType
			)
		{
			//Arrange
			Book productOne = new Book(productOneName, productOneCost, productOneMarkup, productOneQuantity, productOneProductType);

			Book expectedProduct = new Book(expectedName, expectedCost, expectedMarkup, expectedQuantity, expectedProductType);
			//Act
			var actualProduct = productOne - productsNumber;
			//Assert
			Assert.AreEqual(expectedProduct, actualProduct);
		}

		[TestCase("ProductOne", 10, 1.5, 2, "Product", "ProductOne", 20, 1.2, 3, "Product", "ProductOne", 20, 1.2, 3, "Product")]
		[TestCase("ProductTwo", 20, 1.6, 5, "Product", "ProductTwo", 30, 1.3, 4, "Product", "ProductTwo", 30, 1.3, 4, "Product")]
		[TestCase("ProductThree", 30, 1.7, 6, "Product", "ProductThree", 40, 1.4, 5, "Product", "ProductThree", 40, 1.4, 5, "Product")]
		public void GivenOperatorPhoneToBook_WhenClassesFieldsIsPositive_ThenOutIsBook(
			string productOneName, decimal productOneCost, double productOneMarkup, int productOneQuantity, string productOneProductType,
			string productTwoName, decimal productTwoCost, double productTwoMarkup, int productTwoQuantity, string productTwoProductType,
			string expectedName, decimal expectedCost, double expectedMarkup, int expectedQuantity, string expectedProductType
			)
		{
			//Arrange
			Book productOne = new Book(productOneName, productOneCost, productOneMarkup, productOneQuantity, productOneProductType);
			Phone productTwo = new Phone(productTwoName, productTwoCost, productTwoMarkup, productTwoQuantity, productTwoProductType);
			Book expectedProduct = new Book(expectedName, expectedCost, expectedMarkup, expectedQuantity, expectedProductType);
			Book actualProduct = productOne;
			//Act
			actualProduct = (Book)productTwo;
			//Assert
			Assert.AreEqual(expectedProduct, actualProduct);
		}

		[TestCase("ProductOne", 10, 1.5, 2, "Product", 1500)]
		[TestCase("ProductTwo", 20, 1.6, 5, "Product", 3200)]
		[TestCase("ProductThree", 30, 1.7, 6, "Product", 5100)]
		public void GivenOperatorInt_WhenClassesFieldsIsPositive_ThenOutIsCentsPriceProduct(
			string productOneName, decimal productOneCost, double productOneMarkup, int productOneQuantity, string productOneProductType,
			int expectedProductsPrice)
		{
			//Arrange
			Book productOne = new Book(productOneName, productOneCost, productOneMarkup, productOneQuantity, productOneProductType);
			//Act
			int actualProductsPrice = (int)productOne;
			//Assert
			Assert.AreEqual(expectedProductsPrice, actualProductsPrice);
		}

		[TestCase("ProductOne", 10, 1.5, 2, "Product", 15)]
		[TestCase("ProductTwo", 20, 1.6, 5, "Product", 32)]
		[TestCase("ProductThree", 30, 1.7, 6, "Product", 51)]
		public void GivenOperatorFloat_WhenClassesFieldsIsPositive_ThenOutIsFloatPriceProduct(
			string productOneName, decimal productOneCost, double productOneMarkup, int productOneQuantity, string productOneProductType,
			float expectedProductsPrice)
		{
			//Arrange
			Book productOne = new Book(productOneName, productOneCost, productOneMarkup, productOneQuantity, productOneProductType);
			//Act
			float actualProductsPrice = (float)productOne;
			//Assert
			Assert.AreEqual(expectedProductsPrice, actualProductsPrice);
		}

		[TestCase("ProductOne", 10, 1.5, 2, "Product", 15)]
		[TestCase("ProductTwo", 20, 1.6, 5, "Product", 32)]
		[TestCase("ProductThree", 30, 1.7, 6, "Product", 51)]
		public void GivenOperatorDouble_WhenClassesFieldsIsPositive_ThenOutIsDoublePriceProduct(
			string productOneName, decimal productOneCost, double productOneMarkup, int productOneQuantity, string productOneProductType,
			double expectedProductsPrice)
		{
			//Arrange
			Book productOne = new Book(productOneName, productOneCost, productOneMarkup, productOneQuantity, productOneProductType);
			//Act
			double actualProductsPrice = (double)productOne;
			//Assert
			Assert.AreEqual(expectedProductsPrice, actualProductsPrice);
		}

		[TestCase(null, 10, 1.5, 2, "Product")]
		[TestCase(null, 20, 1.6, 5, "Product")]
		[TestCase(null, 30, 1.7, 6, "Product")]
		public void GivenGetPrice_WhenClassesFieldsNameIsNULL_ThenOutIsWxeption(
			string productOneName, decimal productOneCost, double productOneMarkup, int productOneQuantity, string productOneProductType)
		{
			//Assert
			Assert.Throws<ProductExceptions>(() => new Book(productOneName, productOneCost, productOneMarkup, productOneQuantity, productOneProductType));
		}

		[TestCase("ProductOne", -10, 1.5, 2, "Product")]
		[TestCase("ProductTwo", -20, 1.6, 5, "Product")]
		[TestCase("ProductThree", -30, 1.7, 6, "Product")]
		public void GivenGetPrice_WhenClassesFieldsCostIsNotPositive_ThenOutIsWxeption(
			string productOneName, decimal productOneCost, double productOneMarkup, int productOneQuantity, string productOneProductType)
		{
			//Assert
			Assert.Throws<ProductExceptions>(() => new Book(productOneName, productOneCost, productOneMarkup, productOneQuantity, productOneProductType));
		}

		[TestCase("ProductOne", 10, -1.5, 2, "Product")]
		[TestCase("ProductTwo", 20, -1.6, 5, "Product")]
		[TestCase("ProductThree", 30, -1.7, 6, "Product")]
		public void GivenGetPrice_WhenClassesFieldsMarkupIsNotPositive_ThenOutIsWxeption(
			string productOneName, decimal productOneCost, double productOneMarkup, int productOneQuantity, string productOneProductType)
		{
			//Assert
			Assert.Throws<ProductExceptions>(() => new Book(productOneName, productOneCost, productOneMarkup, productOneQuantity, productOneProductType));
		}

		[TestCase("ProductOne", 10, 1.5, -2, "Product")]
		[TestCase("ProductTwo", 20, 1.6, -5, "Product")]
		[TestCase("ProductThree", 30, 1.7, -6, "Product")]
		public void GivenGetPrice_WhenClassesFieldsQuantityIsNotPositive_ThenOutIsWxeption(
			string productOneName, decimal productOneCost, double productOneMarkup, int productOneQuantity, string productOneProductType)
		{
			//Assert
			Assert.Throws<ProductExceptions>(() => new Book(productOneName, productOneCost, productOneMarkup, productOneQuantity, productOneProductType));
		}


	}
}