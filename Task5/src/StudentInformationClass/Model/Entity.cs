using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationClass
{
    /// <summary>
    /// Abstract entity class.
    /// </summary>
    [Serializable]
    public abstract class Entity : IComparable
    {
        /// <summary>
        /// Property Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Method for compare objects.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj is Entity item)
            {
                return Id.CompareTo(item.Id);
            }
            else
            {
                throw new ArgumentNullException();
            }

        }

        /// <summary>
        /// Comparing one StudentTestResultRepository with another.
        /// </summary>
        /// <param name="obj">The compared StudentTestResultRepository.</param>
        /// <returns>True if equal. False if not equal.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Entity x = (Entity)obj;
            return Id.Equals(x.Id);
        }

        /// <summary>
        /// Calculate hash code.
        /// </summary>
        /// <returns>The total hash code.</returns>
        public override int GetHashCode() => Id.GetHashCode();
    }
}
