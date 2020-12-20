
using BoxWithFiguresLibrary;
using Shapes.Model.Lib;
using System;
using System.Collections.Generic;
using System.IO;

namespace XMLStreamReaderWriter
{
	class XMLStreamReaderWriter
	{
		/// <summary>
		/// Static method for serialization GirlsBoxWithFigures class instance to XML-file using StreamWriter class
		/// </summary>
		/// <param name="box"></param>
		/// <param name="filePath"></param>
		public static void WriteToXmlFileFromBox(BoxWithFigures box, string filePath)
		{
			using (StreamWriter stream = new StreamWriter(filePath))
			{
				stream.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
				stream.WriteLine($"<{box.GetType().Name}>");

				foreach (BaseShape figure in box.Figures)
				{
					stream.WriteLine($"\t<{figure.GetType().Name}>");

					stream.WriteLine($"\t\t<NameWithParameters>{figure.ToString()}</NameWithParameters>");
					stream.WriteLine($"\t\t<Perimeter>{figure.Perimeter}</Perimeter>");
					stream.WriteLine($"\t\t<Area>{figure.Area}</Area>");

					stream.WriteLine($"\t</{figure.GetType().Name}>");
				}

				stream.WriteLine($"</{box.GetType().Name}>");
				stream.Close();
			}
		}

		/// <summary>
		/// Static method for deserialization list of abstract figures from XML-file using StreamReader class
		/// </summary>
		/// <param name="filePath"></param>
		/// <returns></returns>
		public static List<BaseShape> ReadFromXmlFileToList(string filePath)
		{
			List<BaseShape> figures = new List<BaseShape>();

			using (StreamReader stream = new StreamReader(filePath))
			{
				while (!stream.EndOfStream)
				{
					string currentString = stream.ReadLine();

					if (currentString.Contains("<NameWithParameters>"))
					{
						figures.Add(StringReader.GetFigureFromString(currentString));
					}
				}
			}
			return figures;
		}
	}
}
