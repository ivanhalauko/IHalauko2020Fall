using NUnit.Framework;
using Shapes.Model.Lib;
using Figures.Model.Lib.Enums;
using Figures.Model.Lib.FigUserException;

namespace Figures.Model.Lib.Figures.Tests
{
	/// <summary>
	/// Tests for testing PaperCircle class.
	/// </summary>
	[TestFixture()]
	public class PaperCircleTests
	{
		/// <summary>
		/// Test case to testing cutting.
		/// </summary>
		/// <param name="shapesFirstRadius">Figure's first length.</param>
		/// <param name="shapesSecondRadius">Figure's second length.</param>
		/// <param name="expectedResult">Expected result.</param>
		[TestCase(0.5, "Black", 0.6, "Yellow", "The area cutting shape 1,13 can not be larger than the current shape0,79")]
		[TestCase(0.4, "Black", 0.6, "Yellow", "The area cutting shape 1,13 can not be larger than the current shape0,5")]
		[TestCase(1, "Black", 2, "Black", "The area cutting shape 12,57 can not be larger than the current shape3,14")]
		public void GivenGetToCutCircleFromShape_WhenRadiusIsPositive_ThenOutIsException(
			double shapesFirstRadius, ColorEnum colorFirst,
			double shapesSecondRadius, ColorEnum colorSecond,
			string expectedResult)
		{
			//Arrange
			PaperCircle currentShape = new PaperCircle(shapesFirstRadius, colorFirst);
			PaperCircle cuttingShape = new PaperCircle(shapesSecondRadius, colorSecond);
			//Act
			var ex = Assert.Throws<ShapesUserException>(() => new PaperCircle(currentShape, cuttingShape));
			//Assert
			Assert.That(ex.Message, Is.EqualTo(expectedResult));
		}

		/// <summary>
		/// Test case to testing cutting.
		/// </summary>
		/// <param name="shapesFirstRadius">Figure's first length.</param>
		/// <param name="shapesSecondRadius">Figure's second length.</param>
		/// <param name="expectedResult">Expected result.</param>
		[TestCase(0.5,  "Black", 0.5,  "Yellow", "The color of the cutting shape Yellow have to equal the current shape Black")]
		[TestCase(2,  "Black", 1,  "Yellow", "The color of the cutting shape Yellow have to equal the current shape Black")]
		[TestCase(5,  "Blue",4,  "Black", "The color of the cutting shape Black have to equal the current shape Blue")]
		public void GivenGetToCutCircleFromShape_WhenRadiusIsPositive_ThenOutIsColorException(
			double shapesFirstRadius,  ColorEnum colorFirst,
			double shapesSecondRadius, ColorEnum colorSecond,
			string expectedResult)
		{
			//Arrange
			PaperCircle currentShape = new PaperCircle(shapesFirstRadius, colorFirst);
			PaperCircle cuttingShape = new PaperCircle(shapesSecondRadius, colorSecond);
			//Act
			var ex = Assert.Throws<FiguresUserException>(() => new PaperCircle(currentShape, cuttingShape));
			//Assert
			Assert.That(ex.Message, Is.EqualTo(expectedResult));
		}

		/// <summary>
		/// Test case to testing painting.
		/// </summary>
		/// <param name="shapesFirstRadius">Figure's first length.</param>
		/// <param name="colorFirst">Figure's first color.</param>
		/// <param name="colorSecond">Figure's next color.</param>
		/// <param name="expectedResult">Expected result.</param>
		[TestCase(0.5,  "Black", "Yellow", "The figure colored  Black you can not change color.")]
		[TestCase(0.5,  "Green", "Yellow", "The figure colored  Green you can not change color.")]
		[TestCase(1,  "Blue", "Black", "The figure colored  Blue you can not change color.")]
		public void GivenGetToPaintCircle_WhenRadiusIsPositive_ThenOutIsFigurePaintedException(
			double shapesFirstRadius, ColorEnum colorFirst,
			ColorEnum colorSecond,
			string expectedResult)
		{
			//Arrange
			PaperCircle currentShape = new PaperCircle(shapesFirstRadius, colorFirst);
			//Act
			var ex = Assert.Throws<FiguresUserException>(() => currentShape.Color = colorSecond);
			//Assert
			Assert.That(ex.Message, Is.EqualTo(expectedResult));
		}

		/// <summary>
		/// Test case to testing painting.
		/// </summary>
		/// <param name="shapesFirstRadius">Figure's first length.</param>
		/// <param name="shapesFirstWidth">Figure's first width.</param>
		/// <param name="colorFirst">Figure's first color.</param>
		/// <param name="colorSecond">Figure's next color.</param>
		/// <param name="expectedResult">Expected result.</param>
		[TestCase(0.5, null, "Yellow", "The figure painted to Yellow sucсesessfully.")]
		[TestCase(0.5, "Green", "Yellow", "The figure colored  Green you can not change color.")]
		[TestCase(1, "Blue", "Black", "The figure colored  Blue you can not change color.")]
		public void GivenGetToPaintCircle_WhenRadiusIsPositive_ThenOutIsFigurePainted(
			double shapesFirstRadius, ColorEnum colorFirst,
			ColorEnum colorSecond,
			string expectedResult)
		{
			//Arrange
			PaperCircle currentShape = new PaperCircle(shapesFirstRadius, colorFirst);
			//Act
			var ex = Assert.Throws<FiguresUserException>(() => currentShape.Color = colorSecond);
			//Assert
			Assert.That(ex.Message, Is.EqualTo(expectedResult));
		}
	}
}