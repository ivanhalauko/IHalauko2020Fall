using NUnit.Framework;
using AVLTreeLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}