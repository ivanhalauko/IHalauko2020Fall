using NUnit.Framework;
using Figures.Model.Lib.Figures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Figures.Model.Lib.Enums;
using Figures.Model.Lib.FigUserException;
using Shapes.Model.Lib;

namespace Figures.Model.Lib.Figures.Tests
{
	/// <summary>
	/// Tests for testing PaperRectangle class.
	/// </summary>
	[TestFixture()]
	public class PaperRectangleTests
	{
		/// <summary>
		/// Test case to testing cutting.
		/// </summary>
		/// <param name="shapesFirstLength">Figure's first length.</param>
		/// <param name="shapesFirstWidth">Figure's first width.</param>
		/// <param name="shapesSecondLength">Figure's second length.</param>
		/// <param name="shapesSecondWidth">Figure's second width.</param>
		/// <param name="expectedResult">Expected result.</param>
		[TestCase(0.5, 1, "Black", 0.5, 2, "Yellow", "The area cutting shape 1 can not be larger than the current shape0,5")]
		[TestCase(1, 2, "Black", 0.5, 8, "Yellow", "The area cutting shape 4 can not be larger than the current shape2")]
		[TestCase(2, 3, "Black", 1, 11, "Black", "The area cutting shape 11 can not be larger than the current shape6")]
		public void GivenGetToCutRectangleFromShape_WhenLengthWidthIsPositive_ThenOutIsException(
			double shapesFirstLength, double shapesFirstWidth, ColorEnum colorFirst,
			double shapesSecondLength, double shapesSecondWidth, ColorEnum colorSecond,
			string expectedResult)
		{
			//Arrange
			PaperRectangle currentShape = new PaperRectangle(shapesFirstLength, shapesFirstWidth, colorFirst);
			PaperRectangle cuttingShape = new PaperRectangle(shapesSecondLength, shapesSecondWidth, colorSecond);
			//Act
			var ex = Assert.Throws<ShapesUserException>(() => new PaperRectangle(currentShape, cuttingShape));
			//Assert
			Assert.That(ex.Message, Is.EqualTo(expectedResult));
		}

		/// <summary>
		/// Test case to testing cutting.
		/// </summary>
		/// <param name="shapesFirstLength">Figure's first length.</param>
		/// <param name="shapesFirstWidth">Figure's first width.</param>
		/// <param name="shapesSecondLength">Figure's second length.</param>
		/// <param name="shapesSecondWidth">Figure's second width.</param>
		/// <param name="expectedResult">Expected result.</param>
		[TestCase(0.5, 2, "Black", 0.5, 1, "Yellow", "The color of the cutting shape Yellow have to equal the current shape Black")]
		[TestCase(0.5, 8, "Black", 1, 2, "Yellow", "The color of the cutting shape Yellow have to equal the current shape Black")]
		[TestCase(1, 11, "Blue", 2, 3, "Black", "The color of the cutting shape Black have to equal the current shape Blue")]
		public void GivenGetToCutRectangleFromShape_WhenLengthWidthIsPositive_ThenOutIsColorException(
			double shapesFirstLength, double shapesFirstWidth, ColorEnum colorFirst,
			double shapesSecondLength, double shapesSecondWidth, ColorEnum colorSecond,
			string expectedResult)
		{
			//Arrange
			PaperRectangle currentShape = new PaperRectangle(shapesFirstLength, shapesFirstWidth, colorFirst);
			PaperRectangle cuttingShape = new PaperRectangle(shapesSecondLength, shapesSecondWidth, colorSecond);
			//Act
			var ex = Assert.Throws<FiguresUserException>(() => new PaperRectangle(currentShape, cuttingShape));
			//Assert
			Assert.That(ex.Message, Is.EqualTo(expectedResult));
		}

		/// <summary>
		/// Test case to testing painting.
		/// </summary>
		/// <param name="shapesFirstLength">Figure's first length.</param>
		/// <param name="shapesFirstWidth">Figure's first width.</param>
		/// <param name="colorFirst">Figure's first color.</param>
		/// <param name="colorSecond">Figure's next color.</param>
		/// <param name="expectedResult">Expected result.</param>
		[TestCase(0.5, 2, "Black", "Yellow", "The figure colored  Black you can not change color.")]
		//[TestCase(0.5, 8, "Green", "Yellow", "The figure colored  Green you can not change color.")]
		//[TestCase(1, 11, "Blue", "Black", "The figure colored  Blue you can not change color.")]
		public void GivenGetToPaintRectangle_WhenLengthWidthIsPositive_ThenOutIsFigurePaintedException(
			double shapesFirstLength, double shapesFirstWidth, ColorEnum colorFirst,
			ColorEnum colorSecond,
			string expectedResult)
		{
			//Arrange
			PaperRectangle currentShape = new PaperRectangle(shapesFirstLength, shapesFirstWidth, colorFirst);
			//Act
			var ex = Assert.Throws<FiguresUserException>(() => currentShape.Color= colorSecond);
			//Assert
			Assert.That(ex.Message, Is.EqualTo(expectedResult));
		}

		/// <summary>
		/// Test case to testing painting.
		/// </summary>
		/// <param name="shapesFirstLength">Figure's first length.</param>
		/// <param name="shapesFirstWidth">Figure's first width.</param>
		/// <param name="colorFirst">Figure's first color.</param>
		/// <param name="colorSecond">Figure's next color.</param>
		/// <param name="expectedResult">Expected result.</param>
		[TestCase(0.5, 2, null, "Yellow", "The figure painted to Yellow sucсesessfully.")]
		//[TestCase(0.5, 8, "Green", "Yellow", "The figure colored  Green you can not change color.")]
		//[TestCase(1, 11, "Blue", "Black", "The figure colored  Blue you can not change color.")]
		public void GivenGetToPaintRectangle_WhenLengthWidthIsPositive_ThenOutIsFigurePainted(
			double shapesFirstLength, double shapesFirstWidth, ColorEnum colorFirst,
			ColorEnum colorSecond,
			string expectedResult)
		{
			//Arrange
			PaperRectangle currentShape = new PaperRectangle(shapesFirstLength, shapesFirstWidth, colorFirst);
			//Act
			var ex = Assert.Throws<FiguresUserException>(() => currentShape.Color = colorSecond);
			//Assert
			Assert.That(ex.Message, Is.EqualTo(expectedResult));
		}

	}
}