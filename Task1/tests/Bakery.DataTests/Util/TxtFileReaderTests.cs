using NUnit.Framework;

namespace Bakery.Data.Util.Tests
{
	/// <summary>
	/// Test cases to testing class TxtFileReader.
	/// </summary>
	[TestFixture()]
	public class TxtFileReaderTests
	{
		private string _pathToTxtFileDifferentText = @"fileData\DifferentList.txt";
		private string _pathToTxtFiletThreeDifferentProduct = @"fileData\ProductsList.txt";
		private string _fileNotFoundExceptionPathToFile = @"Products.txt";
		private string _directoryNotFoundExceptionPathToFile = @"asd\Products.txt";
		/// <summary>
		/// Test case to testing GetAllText method. 
		/// </summary>
		[TestCase()]
		public void GivenGetAllText_WhenPathtToFileIsDifferentText_ThenOutIsEqual()
		{
			//Arrange
			var expectedResult = "fsfsfsdfsdfsdfds";
			//Act
			var actualText = new TxtFileReader(_pathToTxtFileDifferentText).GetAllText();
			//Assert
			Assert.AreEqual(expectedResult, actualText);
		}

		/// <summary>
		/// Test case to testing GetAllRow method.
		/// </summary>
		[TestCase()]
		public void GivenGetAllRow_WhenPathtToFileIsThreeDifferentProducts_ThenOutIsEqual()
		{
			//Arrange
			string[] expectedResult = new[] { "Bread; 3; 1,3", "Bread; 2; 1,4", "Bread; 1; 2,5" };
			//Act
			var actualText = new TxtFileReader(_pathToTxtFiletThreeDifferentProduct).GetAllRow();
			//Assert
			Assert.AreEqual(expectedResult, actualText);
		}

		/// <summary>
		/// Test case to testing GetAllText method. 
		/// </summary>
		[TestCase()]
		public void GivenGetAllText_WhenPathtToFileIsNotValid_ThenOutIsFileNotFoundException()
		{
			//Assert
			Assert.That(() => new TxtFileReader(_fileNotFoundExceptionPathToFile).GetAllText(), Throws.TypeOf<System.IO.FileNotFoundException>());
		}

		/// <summary>
		/// Test case to testing GetAllRow method.
		/// </summary>
		[TestCase()]
		public void GivenGetAllRow_WhenPathtToFileIsNotValid_ThenOutIsFileNotFoundException()
		{
			//Assert
			Assert.That(() => new TxtFileReader(_fileNotFoundExceptionPathToFile).GetAllText(), Throws.TypeOf<System.IO.FileNotFoundException>());
		}

		/// <summary>
		/// Test case to testing GetAllText method.
		/// </summary>
		[TestCase()]
		public void GivenGetAllText_WhenPathtToFileIsNotValid_ThenOutIsDirectoryNotFoundException()
		{
			//Assert
			Assert.That(() => new TxtFileReader(_directoryNotFoundExceptionPathToFile).GetAllText(), Throws.TypeOf<System.IO.DirectoryNotFoundException>());
		}

		/// <summary>
		/// Test case to testing GetAllRow method.
		/// </summary>
		[TestCase()]
		public void GivenGetAllRow_WhenPathtToFileIsNotValid_ThenOutIsDirectoryNotFoundException()
		{
			//Assert
			Assert.That(() => new TxtFileReader(_directoryNotFoundExceptionPathToFile).GetAllText(), Throws.TypeOf<System.IO.DirectoryNotFoundException>());
		}
	}
}