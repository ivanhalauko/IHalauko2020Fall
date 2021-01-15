using System.Collections.Generic;

namespace StudentInformationClass.Interfaces
{
    /// <summary>
    /// IRepository interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
	public interface IRepository<T>
	{
        /// <summary>
        /// Method show node's of tree.
        /// </summary>
        /// <returns>Nodes of tree.</returns>
        IEnumerable<T> ShowAllTree();

        /// <summary>
        /// Data add.
        /// </summary>
        /// <param name="obj">Oobject.</param>
        void Add(T obj);

        /// <summary>
        /// Comparing one StudentTestResultRepository with another.
        /// </summary>
        /// <param name="obj">The compared StudentTestResultRepository.</param>
        /// <returns>True if equal. False if not equal.</returns>
        bool Equals(object obj);
        
        /// <summary>
        /// Calculate hash code.
        /// </summary>
        /// <returns>The total hash code.</returns>
        int GetHashCode();
    }
}
