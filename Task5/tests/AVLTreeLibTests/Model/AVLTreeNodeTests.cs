using NUnit.Framework;
using AVLTreeLib.Model;
using System.Reflection;

namespace AVLTreeLib.Model.Tests
{
	[TestFixture()]
	public class AVLTreeNodeTests
	{
		/// <summary>
		/// Given create node when T is Int then out is int node.
		/// </summary>
		/// <param name="valueActual">Node's actual value.</param>
		/// <param name="leftActual">Left node's actual value.</param>
		/// <param name="rightActual">Right node's actual value.</param>
		/// <param name="valueExpected">Node's expected value.</param>
		/// <param name="leftExpected">Left node's expected value.</param>
		/// <param name="rightExpected">Right node's expected value.</param>
		[TestCase(6, 5, 7, 6, 5, 7)]
		[TestCase(2, 1, 3, 2, 1, 3)]
		public void GivenCreateNode_WhenTIsInt_ThenOutIsIntNode(
			int valueActual, int leftActual, int rightActual,
			int valueExpected, int leftExpected, int rightExpected)
		{
			//Arrange
			AVLTreeNode<int> actualNode = new AVLTreeNode<int>(valueActual, new AVLTreeNode<int>(leftActual), new AVLTreeNode<int>(rightActual));
			AVLTreeNode<int> expectedNode = new AVLTreeNode<int>(valueExpected, new AVLTreeNode<int>(leftExpected), new AVLTreeNode<int>(rightExpected));

			//Assert
			Assert.AreEqual(expectedNode, actualNode);
		}

		/// <summary>
		/// Given create node when T is string then out is string node.
		/// </summary>
		/// <param name="valueActual">Node's actual value.</param>
		/// <param name="leftActual">Left node's actual value.</param>
		/// <param name="rightActual">Right node's actual value.</param>
		/// <param name="valueExpected">Node's expected value.</param>
		/// <param name="leftExpected">Left node's expected value.</param>
		/// <param name="rightExpected">Right node's expected value.</param>
		[TestCase("b", "a", "c", "b", "a", "c")]
		[TestCase("f", "e", "i", "f", "e", "i")]
		public void GivenCreateNode_WhenTIsString_ThenOutIsStringNode(
			string valueActual, string leftActual, string rightActual,
			string valueExpected, string leftExpected, string rightExpected)
		{
			//Arrange
			AVLTreeNode<string> actualNode = new AVLTreeNode<string>(valueActual, new AVLTreeNode<string>(leftActual), new AVLTreeNode<string>(rightActual));
			AVLTreeNode<string> expectedNode = new AVLTreeNode<string>(valueExpected, new AVLTreeNode<string>(leftExpected), new AVLTreeNode<string>(rightExpected));

			//Assert
			Assert.AreEqual(expectedNode, actualNode);
		}

		/// <summary>
		/// Given compare two nodes value when value is positive int then out zero.
		/// </summary>
		/// <param name="firstValue">First value parameter.</param>
		/// <param name="secondValue">Second value parameter.</param>
		/// <param name="expectedValue">Expected value parameter.</param>
		[TestCase(6, 6, 0)]
		[TestCase(1, 1, 0)]
		public void GivenCompareTwoNodesValue_WhenValueIsPositiveInt_ThenOutZero(
			int firstValue, int secondValue, int expectedValue)
		{
			//Arrange
			AVLTreeNode<int> oneNode = new AVLTreeNode<int>(firstValue);
			//Act
			var actualResult = oneNode.CompareTo(secondValue);
			//Assert
			Assert.AreEqual(expectedValue, actualResult);
		}

		/// <summary>
		/// Given compare two nodes value when value is positive int then out is negative value.
		/// </summary>
		/// <param name="firstValue">First value parameter.</param>
		/// <param name="secondValue">Second value parameter.</param>
		/// <param name="expectedValue">Expected value parameter.</param>
		[TestCase(6, 7, -1)]
		[TestCase(1, 2, -1)]
		public void GivenCompareTwoNodesValue_WhenValueIsPositiveInt_ThenOutIsNegativeValue(
			int firstValue, int secondValue, int expectedValue)
		{
			//Arrange
			AVLTreeNode<int> oneNode = new AVLTreeNode<int>(firstValue);
			//Act
			var actualResult = oneNode.CompareTo(secondValue);
			//Assert
			Assert.AreEqual(expectedValue, actualResult);
		}

		/// <summary>
		/// Given compare two nodes value when value is positive int then out is positive value.
		/// </summary>
		/// <param name="firstValue">First value parameter.</param>
		/// <param name="secondValue">Second value parameter.</param>
		/// <param name="expectedValue">Expected value parameter.</param>
		[TestCase(7, 6, 1)]
		[TestCase(2, 1, 1)]
		public void GivenCompareTwoNodesValue_WhenValueIsPositiveInt_ThenOutIsPositiveValue(
			int firstValue, int secondValue, int expectedValue)
		{
			//Arrange
			AVLTreeNode<int> oneNode = new AVLTreeNode<int>(firstValue);
			//Act
			var actualResult = oneNode.CompareTo(secondValue);
			//Assert
			Assert.AreEqual(expectedValue, actualResult);
		}

		/// <summary>
		/// Given compare two nodes string value when value is not NUL then out is zero value.
		/// </summary>
		/// <param name="firstValue">First value parameter.</param>
		/// <param name="secondValue">Second value parameter.</param>
		/// <param name="expectedValue">Expected value parameter.</param>
		[TestCase("ab", "ab", null)]
		[TestCase("bb", "bb", 0)]
		public void GivenCompareTwoNodesValue_WhenValueIsNotNull_ThenOutIsZeroValue(
			string firstValue, string secondValue, int expectedValue)
		{
			//Arrange
			AVLTreeNode<string> oneNode = new AVLTreeNode<string>(firstValue);
			//Act
			var actualResult = oneNode.CompareTo(secondValue);
			//Assert
			Assert.AreEqual(expectedValue, actualResult);
		}

		/// <summary>
		/// Given compare two nodes string value when value is not NUL then out is positive value.
		/// </summary>
		/// <param name="firstValue">First value parameter.</param>
		/// <param name="secondValue">Second value parameter.</param>
		/// <param name="expectedValue">Expected value parameter.</param>
		[TestCase("cb", "bb", 1)]
		[TestCase("db", "cb", 1)]
		public void GivenCompareTwoNodesValue_WhenValueIsNotNull_ThenOutIsPositiveValue(
			string firstValue, string secondValue, int expectedValue)
		{
			//Arrange
			AVLTreeNode<string> oneNode = new AVLTreeNode<string>(firstValue);
			//Act
			var actualResult = oneNode.CompareTo(secondValue);
			//Assert
			Assert.AreEqual(expectedValue, actualResult);
		}

		/// <summary>
		/// Given compare two nodes string value when value is not NUL then out is negative value.
		/// </summary>
		/// <param name="firstValue">First value parameter.</param>
		/// <param name="secondValue">Second value parameter.</param>
		/// <param name="expectedValue">Expected value parameter.</param>
		[TestCase("ab", "bb", -1)]
		[TestCase("cb", "db", -1)]
		public void GivenCompareTwoNodesValue_WhenValueIsNotNull_ThenOutIsNegativeValue(
			string firstValue, string secondValue, int expectedValue)
		{
			//Arrange
			AVLTreeNode<string> oneNode = new AVLTreeNode<string>(firstValue);
			//Act
			var actualResult = oneNode.CompareTo(secondValue);
			//Assert
			Assert.AreEqual(expectedValue, actualResult);
		}

		/// <summary>
		/// Test Given equal two node's value when values are positive int then out is true.
		/// </summary>
		/// <param name="firstValue">First value parameter.</param>
		/// <param name="secondValue">Second value parameter.</param>
		/// <param name="expectedValue">Expected value parameter.</param>
		[TestCase(7, 7, true)]
		[TestCase(2, 2, true)]
		public void GivenEqualTwoNodes_WhenValueIsPositiveInt_ThenOutIsTrue(
			int firstValue, int secondValue, bool expectedValue)
		{
			//Arrange
			AVLTreeNode<int> oneNode = new AVLTreeNode<int>(firstValue);
			AVLTreeNode<int> secondNode = new AVLTreeNode<int>(secondValue);
			//Act
			var actualResult = oneNode.Equals(secondNode);
			//Assert
			Assert.AreEqual(expectedValue, actualResult);
		}

		/// <summary>
		/// Test Given equal two node's value when values are positive int then out is false.
		/// </summary>
		/// <param name="firstValue">First value parameter.</param>
		/// <param name="secondValue">Second value parameter.</param>
		/// <param name="expectedValue">Expected value parameter.</param>
		[TestCase(1, 7, false)]
		[TestCase(1, 2, false)]
		public void GivenEqualTwoNodes_WhenValueIsPositiveInt_ThenOutIsFalse(
			int firstValue, int secondValue, bool expectedValue)
		{
			//Arrange
			AVLTreeNode<int> oneNode = new AVLTreeNode<int>(firstValue);
			AVLTreeNode<int> secondNode = new AVLTreeNode<int>(secondValue);
			//Act
			var actualResult = oneNode.Equals(secondNode);
			//Assert
			Assert.AreEqual(expectedValue, actualResult);
		}

		/// <summary>
		/// Test Given MaxChildHeight node's value when values are positive int then out is child nodes height int.
		/// </summary>
		/// <param name="nodesRoot">First value parameter.</param>
		/// <param name="leftValue">Left value parameter.</param>
		/// <param name="rightValue">Right value parameter.</param>
		/// <param name="expectedValue">Expected value parameter.</param>
		[TestCase(2, 1, 3, 2)]
		[TestCase(1, 2, 4, 2)]
		public void GivenMaxChildHeightNode_WhenNodesValueIsPositiveInt_ThenOutIsChildNodesHeightInt(
			int root, int leftValue, int rightValue, int expectedValue)
		{
			//Arrange
			AVLTreeNode<int> oneNode = new AVLTreeNode<int>(root);
			oneNode.Left = new AVLTreeNode<int>(leftValue);
			oneNode.Right = new AVLTreeNode<int>(rightValue);

			AVLTreeNode<int> testNode = new AVLTreeNode<int>();
			MethodInfo methodInfo = typeof(AVLTreeNode<int>).GetMethod("MaxChildHeight",
			BindingFlags.NonPublic | BindingFlags.Instance);

			//Act
			var actualResult = methodInfo.Invoke(testNode, new object[] { oneNode });
			//Assert
			Assert.AreEqual(expectedValue, actualResult);
		}

		/// <summary>
		/// Test Given MaxChildHeight node's value when values are positive int then out is Child Nodes Height Int.
		/// </summary>
		/// <param name="nodesRoot">First value parameter.</param>
		/// <param name="leftValue">Left value parameter.</param>
		/// <param name="rightValue">Right value parameter.</param>
		/// <param name="expectedValue">Expected value parameter.</param>
		[TestCase(2, 1, 3, 3)]
		[TestCase(1, 2, 4, 3)]
		public void GivenMaxChildHeightNodes_WhenTwoNodesValueIsPositiveInt_ThenOutIsChildNodesHeightInt(
			int nodesRoot, int leftValue, int rightValue, int expectedValue)
		{
			//Arrange
			AVLTreeNode<int> oneNode = new AVLTreeNode<int>(nodesRoot);
			oneNode.Left = new AVLTreeNode<int>(leftValue);	
			oneNode.Left.Left = new AVLTreeNode<int>(leftValue);
			oneNode.Left.Right = new AVLTreeNode<int>(rightValue);

			oneNode.Right = new AVLTreeNode<int>(rightValue);

			AVLTreeNode<int> testNode = new AVLTreeNode<int>();
			MethodInfo methodInfo = typeof(AVLTreeNode<int>).GetMethod("MaxChildHeight",
			BindingFlags.NonPublic | BindingFlags.Instance);

			//Act
			var actualResult = methodInfo.Invoke(testNode, new object[] { oneNode });
			//Assert
			Assert.AreEqual(expectedValue, actualResult);
		}

	}
}