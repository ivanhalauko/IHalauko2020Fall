using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;

namespace AVLTreeLib.Model.Tests
{
	[TestFixture()]
	public class AVLTreeTests
	{

		/// <summary>
		/// Given AddTo new node When T is int Then Out Is Int Tree.
		/// </summary>
		/// <param name="leftValue">Left value.</param>
		/// <param name="rootsValue">Root's value.</param>
		/// <param name="rightValue">Right value.</param>
		/// <param name="additionalValue">Additional Value to tree.</param>
		[TestCase(0, 1, 2, 3)]
		[TestCase(3, 4, 5, 6)]
		[TestCase(7, 8, 9, 10)]
		public void GivenAddToNewNodeToTree_WhenTIsInt_ThenOutIsIntNode(
			int leftValue, int rootsValue, int rightValue,
			int additionalValue)
		{
			//Arrange

			AVLTreeNode<int> leftNode = new AVLTreeNode<int>(leftValue, left: null, right: null);
			AVLTreeNode<int> rightNode = new AVLTreeNode<int>(rightValue, left: null, right: null);

			AVLTree<int> actualTree = new AVLTree<int>();
			actualTree.Root = new AVLTreeNode<int>(rootsValue,left: leftNode, right: rightNode);

			AVLTree<int> expectedTree = new AVLTree<int>();
			expectedTree.Root = new AVLTreeNode<int>(rootsValue, left: leftNode, right: rightNode);
			AVLTreeNode<int> additionalNode = new AVLTreeNode<int>(additionalValue, left: null, right: null);
			expectedTree.Root.Right.Right = additionalNode;
			
			//Act
			actualTree.AddTo(rightNode, additionalValue);
			bool result = expectedTree.Equals(actualTree);

			//Assert
			Assert.AreEqual(expectedTree, actualTree);
		}

		/// <summary>
		/// Given add when T is int then out is int node.
		/// </summary>
		/// <param name="value">Node's value.</param>
		/// <param name="left">Node's left node value.</param>
		/// <param name="right">>Node's left node value.</param>
		/// <param name="rightRight">Node's right-right node value.</param>
		[TestCase(30, 19, 40, 67)]
		[TestCase(2, 1, 3, 4)]
		public void GivenAdd_WhenTIsInt_ThenOutIsIntNode(int value, int left, int right, int rightRight)
		{
			//Arrange
			AVLTree<int> expectedTree = new AVLTree<int>();
			expectedTree.Root = new AVLTreeNode<int>(
				value: value, 
				left: new AVLTreeNode<int>(left), 
				right: new AVLTreeNode<int>(right, null, new AVLTreeNode<int>(rightRight)));

			AVLTree<int> actualTree = new AVLTree<int>();
			
			//Act
			actualTree.Add(left);
			actualTree.Add(value);
			actualTree.Add(right);
			actualTree.Add(rightRight);

			//Assert
			Assert.AreEqual(expectedTree, actualTree);
		}

		/// <summary>
		/// Given add when T is int then out is int node.
		/// </summary>
		/// <param name="value">Node's value.</param>
		/// <param name="left">Node's left node value.</param>
		/// <param name="right">>Node's left node value.</param>
		/// <param name="rightRight">Node's right-right node value.</param>
		[TestCase("f", "e", "i", "k")]
		[TestCase("b", "a", "c", "d")]
		public void GivenAddWhenTIsStringThenOutIsStringNode(string value, string left, string right, string rightRight)
		{
			//Arrange
			AVLTree<string> expectedTree = new AVLTree<string>();
			expectedTree.Root = new AVLTreeNode<string>(
				value: value, 
				left: new AVLTreeNode<string>(left), 
				right: new AVLTreeNode<string>(right, null, new AVLTreeNode<string>(rightRight)));

			AVLTree<string> actualTree = new AVLTree<string>();

			//Act
			actualTree.Add(left);
			actualTree.Add(value);
			actualTree.Add(right);
			actualTree.Add(rightRight);

			//Assert
			Assert.AreEqual(expectedTree, actualTree);
		}

		/// <summary>
		/// Given In Order Travesal When T Is Int  Then Out Is Result String.
		/// </summary>
		/// <param name="value">Node's value.</param>
		/// <param name="left">Node's left node value.</param>
		/// <param name="right">>Node's left node value.</param>
		/// <param name="rightRight">Node's right-right node value.</param>
		/// <param name="expectedResult">Expected Result string with Node's value.</param>
		[TestCase(30, 19, 40, 67, "19 30 40 67 ")]
		[TestCase(2, 1, 3, 4, "1 2 3 4 ")]
		public void GivenInOrderTravesal_WhenTIsInt_ThenOutIsResultString(
			int value, int left, int right, int rightRight,
			string expectedResult)
		{
			//Arrange
			AVLTree<int> actualTree = new AVLTree<int>();
			actualTree.Add(left);
			actualTree.Add(value);
			actualTree.Add(right);
			actualTree.Add(rightRight);

			string actualResult =null;
			//Act

			foreach (var item in actualTree)
			{
				actualResult += item + " ";
			}

			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

	}
}