using Serializers.Interfaces;
using System.IO;
using System.Xml.Serialization;

namespace Serializers.Serializers
{
    /// <summary>
    /// Xml serializer class.
    /// </summary>
    public class XMLSerializer : ISerialiser
    {
        /// <summary>
        /// Serialize object.
        /// </summary>
        /// <typeparam name="T">Object type.</typeparam>
        /// <param name="obj">Object.</param>
        public void Serialize<T>(T obj, string path)
        {

            var nameOfObjectType = obj.GetType().Name;
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream(path + "/" + nameOfObjectType + ".xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }
        }

        /// <summary>
        /// Deserialize object.
        /// </summary>
        /// <typeparam name="T">Object type.</typeparam>
        /// <param name="pathToFile">Path to file.</param>
        /// <returns>Deserialize object.</returns>
        public T Deserialize<T>(string pathToFile)
        {
            if (!new FileInfo(pathToFile).Exists)
                throw new FileNotFoundException("Path to file is not correct.");

            XmlSerializer formatter = new XmlSerializer(typeof(T));

            T newDeserialaize;

            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                newDeserialaize = (T)formatter.Deserialize(fs);
            }
            return newDeserialaize;
        }
    }
}
