using System;
using NUnit.Framework;
using Shapes.Model.Lib.Shapes;
using ShapesStorage;

namespace Shapes.Storage.Lib.Tests
{
	/// <summary>
	/// Test's class for ShapesStorage's class methods.
	/// </summary>
	[TestFixture]
	public class ShapesStorageTests
	{
		BaseCircleShape baseCircleOne = new BaseCircleShape(3);
		BaseCircleShape baseCircleTwo = new BaseCircleShape(4);
		BaseCircleShape baseCircleThree = new BaseCircleShape(5);
		BaseSquareShape baseSquareOne = new BaseSquareShape(1);
		BaseSquareShape baseSquareTwo = new BaseSquareShape(2);
		BaseSquareShape baseSquareThree = new BaseSquareShape(3);
		BaseTrapezeShape baseTrapezeOne = new BaseTrapezeShape(4, 2, 1.1, 1.1);
		BaseTrapezeShape baseTrapezeTwo = new BaseTrapezeShape(5, 3, 2.1, 2.1);
		BaseTrapezeShape baseTrapezeThree = new BaseTrapezeShape(6, 4, 3.1, 3.1);

		/// <summary>
		/// Given Add Shape Method New Shape When New Shapes Then Out Is True.
		/// </summary>
		[Test]
		public void GivenAddShapeMethodNewShape_WhenNewShapes_ThenOutIsTrue()
		{
			//Arrange
			//Act
			Store actualStore = new Store();
			actualStore.AddShape(baseCircleOne);
			actualStore.AddShape(baseCircleTwo);
			actualStore.AddShape(baseCircleThree);
			actualStore.AddShape(baseSquareOne);
			actualStore.AddShape(baseSquareTwo);
			actualStore.AddShape(baseSquareThree);
			actualStore.AddShape(baseTrapezeOne);
			actualStore.AddShape(baseTrapezeTwo);
			actualStore.AddShape(baseTrapezeThree);

			Store expectedStore = new Store();
			expectedStore.AddShape(baseCircleOne);
			expectedStore.AddShape(baseCircleTwo);
			expectedStore.AddShape(baseCircleThree);
			expectedStore.AddShape(baseSquareOne);
			expectedStore.AddShape(baseSquareTwo);
			expectedStore.AddShape(baseSquareThree);
			expectedStore.AddShape(baseTrapezeOne);
			expectedStore.AddShape(baseTrapezeTwo);
			expectedStore.AddShape(baseTrapezeThree);

			//Assert		
			Assert.AreEqual(expectedStore, actualStore);
		}
		/// <summary>
		/// Given Add Shape Method New Shape When New Shapes Then Out IsException.
		/// </summary>
		[Test]
		public void GivenAddShapeMethodNewShape_WhenNewShapes_ThenOutIsException()
		{
			//Arrange
			Store shapesStore = new Store();
			//Act
			shapesStore.AddShape(baseCircleOne);
			shapesStore.AddShape(baseCircleTwo);
			//Assert		
			Assert.Throws<Exception>(() => shapesStore.AddShape(baseCircleOne));
		}

		/// <summary>
		/// Given Sum All Perimetr Shape Method When New Shapes Then Out Is Total Value.
		/// </summary>
		[Test]
		public void GivenSumAllPerimetrShapeMethod_WhenNewShapes_ThenOutIsTotalValue()
		{
			//Arrange
			Store shapesStore = new Store();
			//Act
			shapesStore.AddShape(baseCircleOne);
			shapesStore.AddShape(baseCircleTwo);

			var actualResult = shapesStore.SumAllFiguresPerimeters();
			var expectedResult = 43.980000000000004d;
			//Assert		
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Given Sum All Perimetr Shape Method When New Shapes Then Out Is Total Value.
		/// </summary>
		[Test]
		public void GivenSumAllAreasShapeMethod_WhenNewShapes_ThenOutIsTotalValue()
		{
			//Arrange
			Store shapesStore = new Store();
			//Act
			shapesStore.AddShape(baseCircleOne);
			shapesStore.AddShape(baseCircleTwo);

			var actualResult = shapesStore.SumAllFiguresAreas();
			var expectedResult = 78.540000000000006d;
			//Assert		
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Given Averages All Perimetr Shape Method When New Shapes Then Out Is Averages Value.
		/// </summary>
		[Test]
		public void GivenAveragesAllPerimetrShapeMethod_WhenNewShapes_ThenOutIsAverageValue()
		{
			//Arrange
			Store shapesStore = new Store();
			//Act
			shapesStore.AddShape(baseCircleOne);
			shapesStore.AddShape(baseCircleTwo);

			var actualResult = shapesStore.AverageAllFiguresPerimeters();
			var expectedResult = 21.990000000000002d;
			//Assert		
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Given Average All Perimetr Shape Method When New Shapes Then Out Is Average Value.
		/// </summary>
		[Test]
		public void GivenAverageAllAreasShapeMethod_WhenNewShapes_ThenOutIsAverageValue()
		{
			//Arrange
			Store shapesStore = new Store();
			//Act
			shapesStore.AddShape(baseCircleOne);
			shapesStore.AddShape(baseCircleTwo);

			var actualResult = shapesStore.AverageAllFiguresAreas();
			var expectedResult = 39.270000000000003d;
			//Assert		
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Given Average All Perimetr Shape Method When New Shapes Then Out Is Average Value.
		/// </summary>
		[Test]
		public void GivenLargerAreaFromShapeMethod_WhenNewShapes_ThenOutIsLargerAreaValue()
		{
			//Arrange
			Store shapesStore = new Store();
			//Act
			shapesStore.AddShape(baseCircleOne);
			shapesStore.AddShape(baseCircleTwo);
			shapesStore.AddShape(baseCircleThree);
			shapesStore.AddShape(baseSquareOne);

			var actualResult = shapesStore.GetLargerAreaFromFigures();
			var expectedResult = 78.540000000000006d;
			//Assert		
			Assert.AreEqual(expectedResult, actualResult);
		}



	}
}
