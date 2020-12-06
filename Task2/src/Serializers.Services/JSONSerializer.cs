using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Collections.Generic;
using Serializers.Services.UserException;
using Serializers.Services.Interfaces;

namespace Serializers.Services
{
	/// <summary>
	/// JSONSerializer class.
	/// </summary>
	public class JSONSerializer : IDeserialize, ISerialize
	{
		/// <summary>
		/// Object's serialize class. 
		/// </summary>
		/// <typeparam name="T">Type T parameter.</typeparam>
		/// <param name="obj">Object parameter.</param>
		/// <param name="foldersName">Folder's name parameter.</param>
		public void Serialize<T>(List<T> obj, string foldersName)
		{
			if (foldersName == null)
				SerializerException.PathExists(foldersName);
			if (!Directory.Exists(foldersName))
				Directory.CreateDirectory(foldersName);
			try
			{
				var objTypeName = obj.GetType().Name;
				if (File.Exists(objTypeName + ".json"))
					File.Delete(objTypeName + ".json");
				using (FileStream fs = new FileStream(foldersName + "/" + objTypeName + ".json", FileMode.OpenOrCreate))
				{
					byte[] array = Encoding.Default.GetBytes(JsonConvert.SerializeObject(obj));
					fs.Write(array, 0, array.Length);
				}
			}
			catch
			{
				throw new DirectoryNotFoundException($"File's directory:'{foldersName}' is not exist");
			}
		}

		/// <summary>
		/// Object's deserialize class from file. 
		/// </summary>
		/// <typeparam name="T">Type T parameter.</typeparam>
		/// <param name="foldersName">Folder's name parameter.</param>
		/// <returns>List with objects.</returns>
		public List<T> Deserialize<T>(string foldersName)
		{
			if (!new FileInfo(foldersName).Exists)
				throw new FileNotFoundException($"Path:'{foldersName}' file is not correct");
			List<T> newDeserialize;
			using (FileStream fs = new FileStream(foldersName, FileMode.OpenOrCreate))
			{
				byte[] array = new byte[fs.Length];
				fs.Read(array, 0, array.Length);
				var str = Encoding.Default.GetString(array);

				newDeserialize = JsonConvert.DeserializeObject<List<T>>(str);
			}
			return newDeserialize;
		}
	}
}
