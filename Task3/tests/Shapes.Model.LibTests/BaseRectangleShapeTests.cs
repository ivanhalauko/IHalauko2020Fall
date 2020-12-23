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
		/// <param name="length">Rectangle's length.</param>
		/// <param name="width">Rectangle's width.</param>
		/// <param name="expectedArea">Rectangle's expected perimeter.</param>
		[TestCase(200.1, 10.0, 2001.0)]
		[TestCase(100.1, 10.0, 1001.0)]
		[TestCase(1, 1, 1)]
		public void GivenGetArea_WhenLengthWidthIsPositive_ThenOutIsArea(double length, double width, double expectedArea)
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
		/// <param name="length">Rectangle's length.</param>
		/// <param name="width">Rectangle's width.</param>
		/// <param name="expectedPerimeter">Rectangle's expected perimeter.</param>
		[TestCase(1000.15, 10.0, 2020.3)]
		[TestCase(1, 1, 4)]
		public void GivenGetPerimetr_WhenLengthWidthIsPositive_ThenOutIsPerimetr(double length, double width, double expectedPerimeter)
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
		/// <param name="shapesFirstLength">First rectangle length.</param>
		/// <param name="shapesFirstWidth">First rectangle width.</param>
		/// <param name="shapesSecondLength">Second rectangle length.</param>
		/// <param name="shapesSecondWidth">Second rectangle width.</param>
		/// <param name="expected">Expected True.</param>
		[TestCase(1, 1,1,1, true)]
		public void GivenGetEqualsRectangle_WhenLengthWidthIsPositive_ThenOutIsTrue(
			double shapesFirstLength, double shapesFirstWidth, 
			double shapesSecondLength, double shapesSecondWidth, 
			bool expected)
		{
			//Arrange
			BaseRectangleShape firstRectangle = new BaseRectangleShape(shapesFirstLength, shapesFirstWidth);
			BaseRectangleShape secondRectangle = new BaseRectangleShape(shapesSecondLength, shapesSecondWidth);
			//Act
			var actual = firstRectangle.Equals(secondRectangle);
			//Assert
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// Test case to testing equals.
		/// </summary>
		/// <param name="shapesFirstRadius">Shape's first radius.</param>
		/// <param name="shapesSecondRadius">Shape's second radius.</param>
		/// <param name="expectedResult">Expected result after equals method.</param>
		[TestCase(0.5, 1, 3, 1, false)]
		[TestCase(1, 2, 3, 2, false)]
		[TestCase(2, 3, 3, 3, false)]
		public void GivenGetEqualsRectangle_WhenLengthWidthIsPositive_ThenOutIsFalse(
			double shapesFirstLength, double shapesFirstWidth,
			double shapesSecondLength, double shapesSecondWidth,
			bool expectedResult)
		{
			//Arrange
			BaseRectangleShape firstRectangle = new BaseRectangleShape(shapesFirstLength, shapesFirstWidth);
			BaseRectangleShape secondRectangle = new BaseRectangleShape(shapesSecondLength, shapesSecondWidth);
			//Act
			var actualResult = firstRectangle.Equals(secondRectangle);
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Test case to testing exception.
		/// </summary>
		/// <param name="shapesFirstRadius">Shape's first radius.</param>
		[TestCase(-0.5,-1)]
		[TestCase(-1,-1)]
		[TestCase(-2,-1)]
		public void GivenGetEqualsRectangle_WhenLengthWidthIsNegative_ThenOutIsException(
			double shapesFirstLength, double shapesFirstWidth)
		{
			//Act
			var ex = Assert.Throws<ShapesUserException>(() => new BaseRectangleShape(shapesFirstLength, shapesFirstWidth));
			//Assert
			Assert.That(ex.Message, Is.EqualTo("The value can not be negative"));
		}

		/// <summary>
		/// Test case to testing exception.
		/// </summary>
		/// <param name="shapesFirstLength">Shape's first Length.</param>
		/// <param name="shapesFirstWidth">Shape's first Width.</param>
		[TestCase(0,1)]
		public void GivenGetEqualsRectangle_WhenLengthWidthIsZero_ThenOutIsException(double shapesFirstLength, double shapesFirstWidth)
		{
			//Act
			var ex = Assert.Throws<ShapesUserException>(() => new BaseRectangleShape(shapesFirstLength, shapesFirstWidth));
			//Assert
			Assert.That(ex.Message, Is.EqualTo("The value can not be zero"));
		}

		/// <summary>
		/// Test case to testing cutting.
		/// </summary>
		/// <param name="shapesFirstLength">Shape's first length.</param>
		/// <param name="shapesFirstWidth">Shape's first width.</param>
		/// <param name="shapesSecondLength">Shape's second length.</param>
		/// <param name="shapesSecondWidth">Shape's second width.</param>
		/// <param name="expectedResult">Expected result.</param>
		[TestCase(0.5, 1, 0.5, 2, "The area cutting shape 1 can not be larger than the current shape0,5")]
		[TestCase(1, 2, 0.5, 8, "The area cutting shape 4 can not be larger than the current shape2")]
		[TestCase(2, 3, 1, 11, "The area cutting shape 11 can not be larger than the current shape6")]
		public void GivenGetToCutRectangleFromShape_WhenLengthWidthIsPositive_ThenOutIsException(
			double shapesFirstLength, double shapesFirstWidth,
			double shapesSecondLength, double shapesSecondWidth,
			string expectedResult)
		{
			//Arrange
			BaseRectangleShape currentShape = new BaseRectangleShape(shapesFirstLength, shapesFirstWidth);
			BaseRectangleShape cuttingShape = new BaseRectangleShape(shapesSecondLength, shapesSecondWidth);
			//Act
			var ex = Assert.Throws<ShapesUserException>(() => new BaseRectangleShape(currentShape, cuttingShape));
			//Assert
			Assert.That(ex.Message, Is.EqualTo(expectedResult));
		}

		/// <summary>
		/// Test case to testing cutting.
		/// </summary>
		/// <param name="shapesFirstLength">Shape's first length.</param>
		/// <param name="shapesFirstWidth">Shape's first width.</param>
		/// <param name="shapesSecondLength">Shape's second length.</param>
		/// <param name="shapesSecondWidth">Shape's second width.</param>
		/// <param name="expectedResult">Expected result.</param>
		[TestCase(3, 1, 0.5, 2,1)]
		[TestCase(3, 2, 0.5, 8,4)]
		[TestCase(4, 3, 1, 11,11)]
		public void GivenGetToCutRectangleFromShape_WhenLengthWidthIsPositive_ThenOutIsNotException(
			double shapesFirstLength, double shapesFirstWidth,
			double shapesSecondLength, double shapesSecondWidth,
			double expectedResult)
		{
			//Arrange
			BaseRectangleShape currentShape = new BaseRectangleShape(shapesFirstLength, shapesFirstWidth);
			BaseRectangleShape cuttingShape = new BaseRectangleShape(shapesSecondLength, shapesSecondWidth);
			//Act
			BaseRectangleShape actualShape = new BaseRectangleShape(currentShape, cuttingShape);
			var actualResult = actualShape.Area;
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}