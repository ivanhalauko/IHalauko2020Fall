using NUnit.Framework;
using AVLTreeLib.Model;

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


    }
}