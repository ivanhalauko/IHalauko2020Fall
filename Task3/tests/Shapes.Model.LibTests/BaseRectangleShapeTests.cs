using NUnit.Framework;

namespace Shapes.Model.Lib.Tests
{
	/// <summary>
	/// Test cases to testing class BaseRectangleShape.
	/// </summary>
	[TestFixture()]
	public class BaseRectangleShapeTests
	{
		/// <summary>
		/// Test case to testing property area.
		/// </summary>
		/// <param name="length"></param>
		/// <param name="width"></param>
		/// <param name="expectedArea"></param>
		[TestCase(-100.1, -10.0, 1001.0)]
		[TestCase(100.1, 10.0, 1001.0)]
		[TestCase(0.0, 0.0, 0)]
		public void AreaPropertyRectangleTest(double length, double width, double expectedArea)
		{
			//Arrange
			BaseRectangleShape rectangle = new BaseRectangleShape(length, width);
			//Act
			var actualArea = rectangle.Area;
			//Assert
			Assert.AreEqual(expectedArea, actualArea);
		}

		/// <summary>
		/// Test case to testing property perimeter.
		/// </summary>
		/// <param name="length"></param>
		/// <param name="width"></param>
		/// <param name="expectedPerimeter"></param>
		[TestCase(-1000.15, -10.0, -2020.3)]
		[TestCase(0.0, 0.0, 0)]
		public void PerimeterPropertyRectangleTest(double length, double width, double expectedPerimeter)
		{
			//Arrange
			BaseRectangleShape rectangle = new BaseRectangleShape(length, width);
			//Act
			var actualPerimeter = rectangle.Perimeter;
			//Assert
			Assert.AreEqual(expectedPerimeter, actualPerimeter);
		}

		/// <summary>
		/// Test case to testing equals.
		/// </summary>
		/// <param name="radius">Circle radius.</param>
		/// <param name="expected">Expected True</param>
		[TestCase(0.0, 0.0, true)]
		public void EqualsRectangleMethodTest(double length, double width, bool expected)
		{
			//Arrange
			BaseRectangleShape actualRectangle = new BaseRectangleShape(length, width);
			BaseRectangleShape expectedRectangle = new BaseRectangleShape(length, width);
			//Act
			var actual = actualRectangle.Equals(expectedRectangle);
			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}