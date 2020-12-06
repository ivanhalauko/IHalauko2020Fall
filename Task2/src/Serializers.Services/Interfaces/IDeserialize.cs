﻿using System.Collections.Generic;

namespace Serializers.Services.Interfaces
{
    /// <summary>
    /// IDeserialize interface
    /// </summary>
    public interface IDeserialize : ISerializer
    {
        /// <summary>
        /// Deserialize object
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="path">path</param>
        /// <returns>Rerrurns object.</returns>
        List<T> Deserialize<T>(string path);
    }
}
