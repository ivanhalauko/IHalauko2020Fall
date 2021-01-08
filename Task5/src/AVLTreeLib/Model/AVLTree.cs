using AVLTreeLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTreeLib.Model
{
	public class AVLTree<T> : IAVLTree<T> where T : IComparable
	{
		/// <summary>
		/// Property of head.
		/// </summary>
		public AVLTreeNode<T> Root { get; set; }
		
		/// <summary>
		/// Quantity nodes of tree.
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// Constructor without parameters.
		/// </summary>
		public AVLTree()
		{
			Root = null;
			Count = 0;
		}

		/// <summary>
		/// Adding method nodes to tree.
		/// </summary>
		/// <param name="value">Node's value.</param>
		public void Add(T value)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Adding method nodes to tree's place.
		/// </summary>
		/// <param name="node">Node.</param>
		/// <param name="value">Node's value.</param>
		public void AddTo(AVLTreeNode<T> node, T value)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Method GetEnumerator.
		/// </summary>
		/// <returns>Returns an enumerator that iterates through a collection.</returns>
		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Method make in order travesal. Sorts the tree's value in ascending order.
		/// </summary>
		/// <returns>Returned tree's elements.</returns>
		public IEnumerable<T> InOrderTravesal()
		{
			throw new NotImplementedException();
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
			AVLTree<T> node = (AVLTree<T>)obj;
			return Root.Equals(node.Root);
		}

		/// <summary>
		/// Calculate hash code.
		/// </summary>
		/// <returns>The total hash code.</returns>
		public override int GetHashCode() => Root.GetHashCode();
	}
}
