using NUnit.Framework;
using Products.Domain.Model;
using Serializers.Services.UserException;
using System.Collections.Generic;
using System.IO;

namespace Serializers.Services.Tests
{
	[TestFixture()]
	public class JSONSerializerTests
	{
		/// <summary>
		/// GivenJsonSerializeBook_WhenPathAndProductsAreExist_ThenOutJsonSerialize.
		/// </summary>
		[TestCase()]
		public void GivenJsonSerializeBook_WhenPathAndProductsAreExist_ThenOutJsonSerializeAndDeserialize()
		{
			//Arrange
			JSONSerializer serializer = new JSONSerializer();
			List<Book> expectedProducts = new List<Book>
			{
				new Book(name:"firstBook",cost: 20, markup: 1.5, quantity: 10,productType: "Literature"),
				new Book(name:"secondBook",cost: 10, markup: 1, quantity: 10,productType: "Literature"),
				new Book(name:"thirdBook",cost: 5, markup: 2, quantity: 10,productType: "Literature")
			};
			string foldersName = "serializeData";
			//Act	
			serializer.Serialize(expectedProducts, foldersName);
			List<Book> actualProduct = serializer.Deserialize<Book>($"{foldersName}/List`1.json");
			//Assert
			Assert.AreEqual(expectedProducts, actualProduct);
		}

		/// <summary>
		/// GivenJsonSerializeBook_WhenPathAndProductsAreExist_ThenOutJsonSerialize.
		/// </summary>
		[TestCase()]
		public void GivenJsonSerializeBook_WhenPathIsNotExist_ThenOutSerializerException()
		{
			//Arrange
			JSONSerializer serializer = new JSONSerializer();
			//Act	
			List<Book> expectedProducts = new List<Book>
			{
				new Book(name:"firstBook",cost: 20, markup: 1.5, quantity: 10,productType: "Literature")
			};

			//Assert
			Assert.Throws<SerializerException>(() => serializer.Serialize(expectedProducts, null));
		}

		/// <summary>
		/// GivenJsonSerializeBook_WhenPathAndProductsAreExist_ThenOutJsonSerialize.
		/// </summary>
		[TestCase()]
		public void GivenJsonDeserializeBook_WhenFolderIsNotExist_ThenOutFileNotFoundException()
		{
			//Arrange
			JSONSerializer serializer = new JSONSerializer();
			string foldersName = "serializeData";
			//Act	
			List<Book> expectedProducts = new List<Book>
			{
				new Book(name:"firstBook",cost: 20, markup: 1.5, quantity: 10,productType: "Literature"),
				new Book(name:"secondBook",cost: 10, markup: 1, quantity: 10,productType: "Literature"),
				new Book(name:"thirdBook",cost: 5, markup: 2, quantity: 10,productType: "Literature")
			};
			serializer.Serialize(expectedProducts, foldersName);
			Directory.Delete(foldersName, true);
			//Assert
			Assert.Throws<FileNotFoundException>(() => serializer.Deserialize<Book>(foldersName));
		}
	}
}