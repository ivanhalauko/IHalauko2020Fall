using System;
using NUnit.Framework;
using Shapes.Model.Lib.Shapes;

namespace Shapes.Model.Lib.Tests
{
	/// <summary>
	/// Class for testing Base Square Shape's methods.
	/// </summary>
	[TestFixture]
	public class BaseSquareShapeTests
	{
		/// <summary>
		/// Test case to testing property area.
		/// </summary>
		/// <param name="length">Side's length.</param>
		/// <param name="expectedArea">Expected square's area.</param>
		[TestCase(-100.1, 10020.009999999998d)]
		[TestCase(100.1, 10020.009999999998d)]
		public void GivenAreaPropertySquareShape_WhenSidesIsPositiveAndNegative_ThenOutIsPositive(double length, double expectedArea)
		{
			//Arrange
			BaseSquareShape square = new BaseSquareShape(length);
			//Act
			var actualArea = square.Area;
			//Assert
			Assert.AreEqual(expectedArea, actualArea);
		}

		/// <summary>
		/// Test case to testing property area.
		/// </summary>
		/// <param name="length">Side's length.</param>
		[TestCase(0.0)]
		public void GivenAreaPropertySquareShape_WhenAllSidesIsPositive_ThenIsException(double length)
		{
			//Arrange
			BaseSquareShape squareShape = new BaseSquareShape(length);
			//Act
			//Assert
			Assert.That(() => squareShape.Area, Throws.TypeOf<Exception>());
		}

		/// <summary>
		/// Test case to testing property perimeter.
		/// </summary>
		/// <param name="length">Side's length.</param>
		/// <param name="expectedPerimeter">Expected square's area.</param>
		[TestCase(-1000.15, 4000.6)]
		public void GivenPerimetrPropertySquareShape_WhenSidesIsPositiveAndNegative_ThenOutIsPositive(double length, double expectedPerimeter)
		{
			//Arrange
			BaseSquareShape square = new BaseSquareShape(length);
			//Act
			var actualPerimeter = square.Perimeter;
			//Assert
			Assert.AreEqual(expectedPerimeter, actualPerimeter);
		}

		/// <summary>
		/// Test case to testing property Perimetr.
		/// </summary>
		/// <param name="length">Side's length.</param>
		[TestCase(0.0)]
		public void GivenPerimetrPropertySquareShape_WhenAllSidesIsPositive_ThenIsException(double length)
		{
			//Arrange
			BaseSquareShape squareShape = new BaseSquareShape(length);
			//Act
			//Assert
			Assert.That(() => squareShape.Perimeter, Throws.TypeOf<Exception>());
		}

		/// <summary>
		/// Test case to testing equals.
		/// </summary>
		/// <param name="length">Side's length.</param>
		/// <param name="expected">Expected square's area.</param>
		[TestCase(2.3, true)]
		[TestCase(5.3, true)]
		public void GivenEqualsPropertySquareShape_WhenSidesIsPositive_ThenOutIsTrue(double length, bool expected)
		{
			//Arrange
			BaseSquareShape actualSquare = new BaseSquareShape(length);
			BaseSquareShape expectedSquare = new BaseSquareShape(length);
			//Act
			var actual = actualSquare.Equals(expectedSquare);
			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
