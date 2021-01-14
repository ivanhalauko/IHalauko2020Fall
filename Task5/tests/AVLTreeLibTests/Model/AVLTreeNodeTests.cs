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

		/// <summary>
		/// Given Insert When TSing Then Out Is Int Node.
		/// </summary>
		/// <param name="actualData">The data that is stored in the node.</param>
		/// <param name="actualLeft">Left node.</param>
		/// <param name="actualRight">Right node.</param>
		/// <param name="expectedData">The data that is stored in the node.</param>
		/// <param name="expectedLeft">Left node.</param>
		/// <param name="expectedRight">Right node.</param>
		[TestCase(5, 3, 1, 5, 3, 1)]
		public void GivenIsertWhenTIsIntThenOutIsIntNode(
			int actualData, int actualLeft, int actualRight,
			int expectedData, int expectedLeft, int expectedRight)
		{
			//Arrange
			AVLTreeNode<int> actualNode = new AVLTreeNode<int>(
				value: actualData,
				left: new AVLTreeNode<int>(actualLeft), 
				right: new AVLTreeNode<int>(actualRight));
			AVLTreeNode<int> expectedNode = new AVLTreeNode<int>(expectedData);
			//Act
			expectedNode.Insert(new AVLTreeNode<int>(expectedLeft));
			expectedNode.Insert(new AVLTreeNode<int>(expectedRight));
			//Assert
			Assert.AreEqual(expectedNode, actualNode);
		}

		/// <summary>
		/// Given Insert When TSing Then Out Is String Node
		/// </summary>
		/// <param name="actualData">The data that is stored in the node.</param>
		/// <param name="actualLeft">Left node.</param>
		/// <param name="actualRight">Right node.</param>
		/// <param name="expectedData">The data that is stored in the node.</param>
		/// <param name="expectedLeft">Left node.</param>
		/// <param name="expectedRight">Right node.</param>
		[TestCase("c", "b", "a", "c", "b", "a")]
		[TestCase("c", "b", "a", "c", "b", "a")]
		public void GivenInsertWhenTSingThenOutIsStringNode(
			string actualData, string actualLeft, string actualRight,
			string expectedData, string expectedLeft, string expectedRight)
		{
			//Arrange
			AVLTreeNode<string> actualNode = new AVLTreeNode<string>(
				value: actualData, 
				left: new AVLTreeNode<string>(actualLeft), 
				right: new AVLTreeNode<string>(actualRight));
			AVLTreeNode<string> expectedNode = new AVLTreeNode<string>(expectedData);
			//Act
			expectedNode.Insert(new AVLTreeNode<string>(expectedLeft));
			expectedNode.Insert(new AVLTreeNode<string>(expectedRight));
			//Assert
			Assert.AreEqual(expectedNode, actualNode);
		}

		/// <summary>
		/// Given replace roots parent link on himself when nodes value is positive int then out is new node int.
		/// </summary>
		/// <param name="leftLeftValue">Node's left-left value.</param>
		/// <param name="leftValue">Node's left value parameter.</param>
		/// <param name="nodeValue">Node's value parameter.</param>
		/// <param name="nodesParentValue">Node's parent value parameter.</param>
		[TestCase(0, 1, 2, 3)]
		[TestCase(5, 7, 10, 22)]
		[TestCase(12, 20, 25, 27)]
		public void GivenReplaceRootsParentLinkOnHimself_WhenNodesValueIsPositiveInt_ThenOutIsNewNodeInt(
			int leftLeftValue, int leftValue, int nodeValue, int nodesParentValue)
		{
			//Arrange
			AVLTreeNode<int> LeftLeftNode = new AVLTreeNode<int>(leftLeftValue, left: null, right: null);           //	root.Parent			3
			AVLTreeNode<int> LeftNode = new AVLTreeNode<int>(leftValue, left: LeftLeftNode, right: null);           //	   			       /	|	root.Parent	|
																													//	root	          2		|	   2		|
			AVLTreeNode<int> node = new AVLTreeNode<int>(value: nodeValue, left: LeftNode, right: null);                //				     /		|	  /			|
			node.Parent = new AVLTreeNode<int>(nodesParentValue, node, right: null);                                //	left		    1		|	 1			|
																													//				   /		|	/			|
			AVLTreeNode<int> expectedResult = new AVLTreeNode<int>(value: nodeValue, left: LeftNode, right: null);  //  leftLeft      0			|  0			|
			expectedResult.Parent = expectedResult;                                                                 //

			//Act
			MethodInfo methodInfo = typeof(AVLTreeNode<int>).GetMethod("ReplaceRoot",
			BindingFlags.NonPublic | BindingFlags.Instance);
			methodInfo.Invoke(node, new object[] { node });

			AVLTreeNode<int> actualResult = node;
			bool Result = actualResult.Equals(expectedResult);
			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// GivenBalanceRRWhenTIsIntThenOutIsIntNode
		/// </summary>
		/// <param name="leftLeftLeftValue">The data that is stored in the node.</param>
		/// <param name="leftLeftValue">Left Left Value node.</param>
		/// <param name="leftValuet">Left Valuet node.</param>
		/// <param name="rootValue">Root Value node before balance.</param>
		[TestCase(5, 7, 8, 9)]
		[TestCase(0, 1, 2, 3)]
		[TestCase(3, 6, 8, 9)]
		public void GivenBalanceRRWhenTIsIntThenOutIsIntNode(
			int leftLeftLeftValue, int leftLeftValue, int leftValue, int rootValue)
		{
			//Arrange
			AVLTreeNode<int> leftLeftLeftNode = new AVLTreeNode<int>(leftLeftLeftValue, left: null, right: null);
			AVLTreeNode<int> leftLeftNode = new AVLTreeNode<int>(leftLeftValue, leftLeftLeftNode,right: null);
			AVLTreeNode<int> leftNode = new AVLTreeNode<int>(leftValue, leftLeftNode, right:null);
			AVLTreeNode<int> actualNotBalancedNode = new AVLTreeNode<int>(rootValue, leftNode, right: null);
			//Expected Node. 
			AVLTreeNode<int> expectedBalancedNode = new AVLTreeNode<int>(rootValue, null, right: null);
			expectedBalancedNode.Parent = leftNode;
			
			//Act
			//Balance with rotation node.
			actualNotBalancedNode.Balance();
			AVLTreeNode<int> actualBalancedNode = actualNotBalancedNode;

			//Assert
			Assert.AreEqual(expectedBalancedNode, actualBalancedNode);
		}

	}
}