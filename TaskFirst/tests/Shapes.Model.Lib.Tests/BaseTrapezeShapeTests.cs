using System;
using NUnit.Framework;
using Shapes.Model.Lib.Shapes;

namespace Shapes.Model.Lib.Tests
{
	/// <summary>
	/// Class for testing Base Trapeze Shape's methods.
	/// </summary>
	[TestFixture]
	public class BaseTrapezeShapeTests
	{
		/// <summary>
		/// Test case to testing property area.
		/// </summary>
		/// <param name="largeBase">Large base.</param>
		/// <param name="smallBase">Small Base.</param>
		/// <param name="leftSideBit">Left Side Bit.</param>
		/// <param name="rightSideBit">Right Side Bit.</param>
		/// <param name="expectedArea">Expected Area value.</param>
		[TestCase(3.1, 1.1, 1.5, 1.5, 2.3478713763747794)]
		[TestCase(4.1, 2.1, 2.5, 2.5, 7.1029923271815507d)]
		public void GivenAreaPropertyTrapezeShape_WhenAllSidesIsPositive_ThenOutIsPositive(double largeBase, double smallBase, double leftSideBit, double rightSideBit, double expectedArea)
		{
			//Arrange
			BaseTrapezeShape trapezeShape = new BaseTrapezeShape(largeBase, smallBase, leftSideBit, rightSideBit);
			//Act
			var actualArea = trapezeShape.Area;
			//Assert
			Assert.AreEqual(expectedArea, actualArea);
		}

		/// <summary>
		/// Test case to testing property area.
		/// </summary>
		/// <param name="largeBase">Large base.</param>
		/// <param name="smallBase">Small Base.</param>
		/// <param name="leftSideBit">Left Side Bit.</param>
		/// <param name="rightSideBit">Right Side Bit.</param>
		[TestCase(0.0, 0.0, 0.0, 0.0)]
		public void GivenAreaPropertyTrapezeShape_WhenAllSidesIsPositive_ThenIsException(double largeBase, double smallBase, double leftSideBit, double rightSideBit)
		{
			//Arrange
			BaseTrapezeShape trapezeShape = new BaseTrapezeShape(largeBase, smallBase, leftSideBit, rightSideBit);
			//Act
			//Assert
			Assert.That(() => trapezeShape.Area, Throws.TypeOf<Exception>());
		}

		/// <summary>
		/// Test case to testing property perimeter.
		/// </summary>
		/// <param name="largeBase">Large base.</param>
		/// <param name="smallBase">Small Base.</param>
		/// <param name="leftSideBit">Left Side Bit.</param>
		/// <param name="rightSideBit">Right Side Bit.</param>
		/// <param name="expectedPerimeter">Expected Perimeter value.</param>
		[TestCase(3.1, 1.1, 1.5, 1.5, 7.2000000000000002d)]
		public void GivenPerimeterPropertyTrapezeShape_WhenAllSidesIsPositive_ThenOutIsPositive(double largeBase, double smallBase, double leftSideBit, double rightSideBit, double expectedPerimeter)
		{
			//Arrange
			BaseTrapezeShape trapezeShape = new BaseTrapezeShape(largeBase, smallBase, leftSideBit, rightSideBit);
			//Act
			var actualPerimeter = trapezeShape.Perimeter;
			//Assert
			Assert.AreEqual(expectedPerimeter, actualPerimeter);
		}

		/// <summary>
		/// Test case to testing property Perimeter.
		/// </summary>
		/// <param name="largeBase">Large base.</param>
		/// <param name="smallBase">Small Base.</param>
		/// <param name="leftSideBit">Left Side Bit.</param>
		/// <param name="rightSideBit">Right Side Bit.</param>
		[TestCase(0.0, 0.0, 0.0, 0.0)]
		public void GivenPerimeterPropertyTrapezeShape_WhenAllSidesIsPositive_ThenIsException(double largeBase, double smallBase, double leftSideBit, double rightSideBit)
		{
			//Arrange
			BaseTrapezeShape trapezeShape = new BaseTrapezeShape(largeBase, smallBase, leftSideBit, rightSideBit);
			//Act
			//Assert
			Assert.That(() => trapezeShape.Perimeter, Throws.TypeOf<Exception>());
		}

		/// <summary>
		/// Test case to testing equals.
		/// </summary>
		/// <param name="radius">Circle radius.</param>
		/// <param name="expected">Expected True</param>

		/// <summary>
		/// Test case to testing equals.
		/// </summary>
		/// <param name="largeBase">Large base.</param>
		/// <param name="smallBase">Small Base.</param>
		/// <param name="leftSideBit">Left Side Bit.</param>
		/// <param name="rightSideBit">Right Side Bit.</param>
		/// <param name="expected">Expected result.</param>
		[TestCase(3.1, 1.1, 1.5, 1.5, true)]
		public void GivenEqualsTrapezeShape_WhenAllSidesIsPositive_ThenOutIsTrue(double largeBase, double smallBase, double leftSideBit, double rightSideBit, bool expected)
		{
			//Arrange
			BaseTrapezeShape actualTrapezeShape = new BaseTrapezeShape(largeBase, smallBase, leftSideBit, rightSideBit);
			BaseTrapezeShape expectedTrapezeShape = new BaseTrapezeShape(largeBase, smallBase, leftSideBit, rightSideBit);
			//Act
			var actual = actualTrapezeShape.Equals(expectedTrapezeShape);
			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
