using NUnit.Framework;

namespace Shapes.Model.Lib.Tests
{
	/// <summary>
	/// Test cases to testing class BaseCircleShape.
	/// </summary>
	[TestFixture()]
	public class BaseCircleShapeTests
	{
		/// <summary>
		/// Test case to testing property area.
		/// </summary>
		/// <param name="radius">Radius</param>
		/// <param name="expectedArea">Expected area.</param>
		[TestCase(100.1, 31478.790000000001)]
		[TestCase(1, 3.14)]
		[TestCase(100.1, 31478.790000000001)]
		public void GivenGetArea_WhenRadiusIsPositive_ThenOutIsArea(double radius, double expectedArea)
		{
			//Arrange
			BaseCircleShape filmCircle = new BaseCircleShape(radius);
			//Act
			var actualArea = filmCircle.Area;
			//Assert
			Assert.AreEqual(expectedArea, actualArea);
		}

		/// <summary>
		/// Test case to testing property perimeter.
		/// </summary>
		/// <param name="radius">Circle radius.</param>
		/// <param name="expectedPerimeter">Expected perimeter.</param>
		[TestCase(10.0, 62.829999999999998d)]
		[TestCase(100.1, 628.95000000000005)]
		[TestCase(5, 31.42)]
		public void GivenGetPerimetr_WhenRadiusIsPositive_ThenOutIsPerimetr(double radius, double expectedPerimeter)
		{
			//Arrange
			BaseCircleShape circle = new BaseCircleShape(radius);
			//Act
			var actualPerimetera = circle.Perimeter;
			//Assert
			Assert.AreEqual(expectedPerimeter, actualPerimetera);
		}

		/// <summary>
		/// Test case to testing equals.
		/// </summary>
		/// <param name="shapesFirstRadius">Shapes first radius.</param>
		/// <param name="shapesSecondRadius">Shapes second radius.</param>
		/// <param name="expectedResult">Expected result after equals method.</param>
		[TestCase(3,3, true)]
		[TestCase(1, 1, true)]
		[TestCase(2, 2, true)]
		public void GivenGetEqualsCircle_WhenRadiusIsPositive_ThenOutIsTrue(double shapesFirstRadius, double shapesSecondRadius, bool expectedResult)
		{
			//Arrange
			BaseCircleShape firstCircle = new BaseCircleShape(shapesFirstRadius);
			BaseCircleShape secondCircle = new BaseCircleShape(shapesSecondRadius);
			//Act
			var actualResult = firstCircle.Equals(secondCircle);
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Test case to testing equals.
		/// </summary>
		/// <param name="shapesFirstRadius">Shapes first radius.</param>
		/// <param name="shapesSecondRadius">Shapes second radius.</param>
		/// <param name="expectedResult">Expected result after equals method.</param>
		[TestCase(0.5, 1, false)]
		[TestCase(1, 2, false)]
		[TestCase(2, 3, false)]
		public void GivenGetEqualsCircle_WhenRadiusIsPositive_ThenOutIsFalse(double shapesFirstRadius, double shapesSecondRadius, bool expectedResult)
		{
			//Arrange
			BaseCircleShape firstCircle = new BaseCircleShape(shapesFirstRadius);
			BaseCircleShape secondCircle = new BaseCircleShape(shapesSecondRadius);
			//Act
			var actualResult = firstCircle.Equals(secondCircle);
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Test case to testing exception.
		/// </summary>
		/// <param name="shapesFirstRadius">Shapes first radius.</param>
		[TestCase(-0.5)]
		[TestCase(-1)]
		[TestCase(-2)]
		public void GivenGetEqualsCircle_WhenRadiusIsPositive_ThenOutIsException(double shapesFirstRadius)
		{
			//Assert
			Assert.Throws<ShapesUserException>(() => new BaseCircleShape(shapesFirstRadius));
		}

		/// <summary>
		/// Test case to testing exception.
		/// </summary>
		/// <param name="shapesFirstRadius">Shapes first radius.</param>
		[TestCase(0)]
		public void GivenGetEqualsCircle_WhenRadiusIsZero_ThenOutIsException(double shapesFirstRadius)
		{
			//Assert
			Assert.Throws<ShapesUserException>(() => new BaseCircleShape(shapesFirstRadius));
		}

	}
}