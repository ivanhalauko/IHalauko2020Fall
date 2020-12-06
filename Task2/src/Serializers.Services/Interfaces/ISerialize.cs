using System.Collections.Generic;

namespace Serializers.Services.Interfaces
{
    public interface ISerialize : ISerializer
    {
        /// <summary>
        /// Serialize
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="obj">Objct</param>
        /// <param name="path">path</param>
        void Serialize<T>(List<T> obj, string foldersName);
    }
}
