using AVLTreeLib.Enum;
using System;

namespace AVLTreeLib.Model
{
    /// <summary>
    /// Node's type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public class AVLTreeNode<T> : IComparable<T> where T : IComparable
	{
        /// <summary>
        /// Field tree.
        /// </summary>
        AVLTree<T> _tree;

        /// <summary>
        /// Root's left descendent.
        /// </summary>
        AVLTreeNode<T> _left;

        /// <summary>
        /// Root's right descendent.
        /// </summary>
        AVLTreeNode<T> _right;

        /// <summary>
        /// Constructor without parameter.
        /// </summary>
        public AVLTreeNode()
        {
        }

        /// <summary>
        /// Constructor AVL tree node class.
        /// </summary>
        /// <param name="value">Value of node.</param>
        public AVLTreeNode(T value)
        {
            Value = value;
        }

        /// <summary>
        /// Node's constructor.
        /// </summary>
        /// <param name="value">Value of node.</param>
        /// <param name="parent">Parent of node.</param>
        public AVLTreeNode(T value, AVLTreeNode<T> parent, AVLTree<T> tree)
        {
            Value = value;
            Parent = parent;
            _tree = tree;
        }

        /// <summary>
        /// Constructor AVL tree node class.
        /// </summary>
        /// <param name="value">Node's value.</param>
        /// <param name="left">Root's left descendent.</param>
        /// <param name="right">Root's right descendent.</param>
        public AVLTreeNode(T value, AVLTreeNode<T> left, AVLTreeNode<T> right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        /// <summary>
        /// Node's parent reference.
        /// </summary>
        public AVLTreeNode<T> Parent { get;set;}

        /// <summary>
        /// Reference on the left descendent.
        /// </summary>
        public AVLTreeNode<T> Left
        {
            get => _left;
         
            set
            {
                _left = value;
                if (_left != null)
                {
                    _left.Parent = this;
                }
            }
        }

        /// <summary>
        /// Reference on the right descendent.
        /// </summary>
        public AVLTreeNode<T> Right
        {
            get => _right;

            set
            {
                _right = value;
                if (_right != null)
                {
                    _right.Parent = this;
                }
            }
        }

        /// <summary>
        /// Node's value.
        /// </summary>
        public T Value { get;set;}

        /// <summary>
        /// Method is implementing IComparable interface.
        /// </summary>
        /// <param name="other">Node for comparison.</param>
        /// <returns>Return 1 if other less then current.</returns>
        public int CompareTo(T other) => Value.CompareTo(other);


        /// <summary>
        /// Property height left tree.
        /// </summary>
        private int LeftHeight
        {
            get => MaxChildHeight(Left);
        }

        /// <summary>
        /// Property of height right tree.
        /// </summary>
        private int RightHeight
        {
            get=> MaxChildHeight(Right);
        }

        /// <summary>
        /// State of tree.
        /// </summary>
        private TreeStateEnum State
        {
            get
            {
                if (LeftHeight - RightHeight > 1)
                {
                    return TreeStateEnum.LeftHeavy;
                }
                if (RightHeight - LeftHeight > 1)
                {
                    return TreeStateEnum.RightHeavy;
                }
                return TreeStateEnum.Balanced;
            }
        }

        /// <summary>
        /// Balance factor.
        /// </summary>
        private int BalanceFactor
        {
            get
            {
                return RightHeight - LeftHeight;
            }
        }

        /// <summary>
        /// Method finds height.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private int MaxChildHeight(AVLTreeNode<T> node)
        {
            if (node != null)
            {
                return 1 + Math.Max(MaxChildHeight(node.Left), MaxChildHeight(node.Right));
            }
            return 0;
        }

        /// <summary>
        /// Method left rotation tree. 
        /// </summary>
        private void LeftRotation()
        {
            AVLTreeNode<T> newRoot = Right;
            ReplaceRoot(newRoot);

            Right = newRoot.Left;
            newRoot.Left = this;

        }

        /// <summary>
        /// Method right rotation tree.
        /// </summary>
        private void RightRotation()
        {
            AVLTreeNode<T> newRoot = Left;
            ReplaceRoot(newRoot);

            Left = newRoot.Right;
            newRoot.Right = this;
        }

        /// <summary>
        /// Method root replace.
        /// </summary>
        /// <param name="newRoot">New root.</param>
        private void ReplaceRoot(AVLTreeNode<T> newRoot)
        {
            if (this.Parent != null)
            {
                if (this.Parent.Left == this)
                {
                    this.Parent.Left = newRoot;
                }
                else if (this.Parent.Right == this)
                {
                    this.Parent.Right = newRoot;
                }
            }
            else
            {
                _tree.Root = newRoot;
            }
            newRoot.Parent = this.Parent;
            this.Parent = newRoot;
        }

        /// <summary>
        /// Balance method.
        /// </summary>
        internal void Balance()
        {
            if (State == TreeStateEnum.RightHeavy)
            {
                LeftRotation();

            }
            else if (State == TreeStateEnum.LeftHeavy)
            {
                RightRotation();
            }
        }

        /// <summary>
        /// Comparing one node with another.
        /// </summary>
        /// <param name="obj">The compared node.</param>
        /// <returns>True if equal. False if not equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            AVLTreeNode<T> node = (AVLTreeNode<T>)obj;
            return Value.Equals(node.Value);
        }

        /// <summary>
        /// Calculate hash code.
        /// </summary>
        /// <returns>The total hash code.</returns>
        public override int GetHashCode() => Value.GetHashCode();
    }
}
