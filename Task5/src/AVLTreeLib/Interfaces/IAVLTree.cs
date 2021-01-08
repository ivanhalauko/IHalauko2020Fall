using AVLTreeLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTreeLib.Interfaces
{
	public interface IAVLTreeLib<T> where T : IComparable
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
		/// Adding method nodes to tree.
		/// </summary>
		/// <param name="value">Node's value.</param>
		public void Add(T value);

		/// <summary>
		/// Adding method nodes to tree's place.
		/// </summary>
		/// <param name="node">Node.</param>
		/// <param name="value">Node's value.</param>
		public void AddTo(AVLTreeNode<T> node, T value);

		/// <summary>
		/// Method make in order travesal. Sorts the tree's value in ascending order.
		/// </summary>
		/// <returns>Returned tree's elements.</returns>
		public IEnumerable<T> InOrderTravesal();

		/// <summary>
		/// Method GetEnumerator.
		/// </summary>
		/// <returns>Returns an enumerator that iterates through a collection.</returns>
		public IEnumerator<T> GetEnumerator();

		
	}
}
