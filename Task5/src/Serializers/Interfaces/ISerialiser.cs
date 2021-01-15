
namespace Serializers.Interfaces
{
    /// <summary>
    /// Interface serialiser.
    /// </summary>
    public interface ISerialiser
    {
        /// <summary>
        /// Method to serialize some object.
        /// </summary>
        /// <typeparam name="T">Object's type.</typeparam>
        /// <param name="obj">Object's name.</param>
        /// <param name="path">Path to serialize.</param>
        void Serialize<T>(T obj, string path);

        /// <summary>
        ///  Method to serialize some object.
        /// </summary>
        /// <typeparam name="T">Object's type.</typeparam>
        /// <param name="pathToFile">Path to file serialize.</param>
        /// <returns></returns>
        T Deserialize<T>(string pathToFile);

    }
}
