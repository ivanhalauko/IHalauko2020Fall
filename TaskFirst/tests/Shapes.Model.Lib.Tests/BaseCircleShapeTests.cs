using System;
using NUnit.Framework;
using Shapes.Model.Lib.Shapes;

namespace Shapes.Model.Lib.Tests
{
	/// <summary>
	/// Test's class for testing CircleShape's class methods.
	/// </summary>
	[TestFixture]
	public class BaseCircleShapeTests
	{
		/// <summary>
		/// Test case to testing property area.
		/// </summary>
		/// <param name="radius">Circle's radius value.</param>
		/// <param name="expectedArea">Circle's expected area value.</param>
		[TestCase(100.1, 31478.790000000001)]
		[TestCase(-100.1, 31478.790000000001)]
		public void GivenAreaPropertyCircleShape_WhenRadiusIsPositiveAndNegative_ThenOutIsPositive(double radius, double expectedArea)
		{
			//Arrange
			BaseCircleShape circleShape = new BaseCircleShape(radius);
			//Act
			var actualArea = circleShape.Area;
			//Assert
			Assert.AreEqual(expectedArea, actualArea);
		}

		/// <summary>
		/// Test case to testing property area.
		/// </summary>
		/// <param name="length">Side's length.</param>
		[TestCase(0.0)]
		public void GivenAreaPropertyCircleShape_WhenrRadiusIsNull_ThenIsException(double radius)
		{
			//Arrange
			BaseCircleShape circleShape = new BaseCircleShape(radius);
			//Act
			//Assert
			Assert.That(() => circleShape.Area, Throws.TypeOf<Exception>());
		}

		/// <summary>
		/// Test case to testing property perimeter.
		/// </summary>
		/// <param name="radius">Circle radius.</param>
		/// <param name="expectedPerimeter">Expected perimeter.</param>
		[TestCase(10.0, 62.829999999999998d)]
		[TestCase(-100.1, 628.95000000000005)]
		public void GivenPerimetrPropertyCircleShape_WhenRadiusIsPositiveAndNegative_ThenOutIsPositive(double radius, double expectedPerimeter)
		{
			//Arrange
			BaseCircleShape circleShape = new BaseCircleShape(radius);
			//Act
			var actualPerimeter = circleShape.Perimeter;
			//Assert
			Assert.AreEqual(expectedPerimeter, actualPerimeter);
		}

		/// <summary>
		/// Test case to testing property area.
		/// </summary>
		/// <param name="radius">Circle's radius.</param>
		[TestCase(0.0)]
		public void GivenPerimetrPropertyCircleShape_WhenrRadiusIsNull_ThenIsException(double radius)
		{
			//Arrange
			BaseCircleShape circleShape = new BaseCircleShape(radius);
			//Act
			//Assert
			Assert.That(() => circleShape.Perimeter, Throws.TypeOf<Exception>());
		}

		/// <summary>
		/// Test case to testing equals.
		/// </summary>
		/// <param name="radius">Circle radius.</param>
		/// <param name="expected">Expected True</param>
		[TestCase(0.0, true)]
		public void GivenEqualsPropertyCircleShape_WhenSidesIsPositive_ThenOutIsTrue(double radius, bool expected)
		{
			//Arrange
			BaseCircleShape actualCircle = new BaseCircleShape(radius);
			BaseCircleShape expectedCircle = new BaseCircleShape(radius);
			//Act
			var actual = actualCircle.Equals(expectedCircle);
			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
