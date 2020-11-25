using System;
using System.Collections.Generic;
using Bakery.Data.Interfaces;
using Bakery.Data.Util;
using Bakery.Model.Products;

namespace Bakery.Data.Repositories
{
    /// <summary>
    /// A class to get all shapes from a text file in array.
    /// </summary>
	public class TxtBakeryData : IBakeryData
    {
        /// <summary>
        /// Field TxtFileReader
        /// </summary>
        private TxtFileReader _txtFileReader;

        /// <summary>
        /// Constructor to initialize field _txtFileReader.
        /// </summary>
        /// <param name="pathToTxtFile">Parameter path to the file.</param>
        public TxtBakeryData(string pathToTxtFile)
        {
            _txtFileReader = new TxtFileReader(pathToTxtFile);
        }
        /// <summary>
        /// Method to parsing txt file in object array. 
        /// </summary>
        /// <returns>Returns IEnumerable list with shapes.</returns>
		public BaseAbstractProduct[] GetProductArray()
        {
            string[] dataFromTxt = _txtFileReader.GetAllRow();
            List<BaseAbstractProduct> bakeryProducts = new List<BaseAbstractProduct>();

            try
            {
                foreach (var rowItem in dataFromTxt)
                {
                    string[] bakeryParameters = rowItem.Split(';');

                    string typeOfBakery = bakeryParameters[0];

                    switch (typeOfBakery)
                    {
                        case "Bread":
                            bakeryProducts.Add(new Bread(quantityProduct: Convert.ToInt32(bakeryParameters[1]), Convert.ToDecimal(bakeryParameters[2])));
                            break;
     
                        default:
                            break;
                    }
                }
            }
            catch (FormatException)
            {
                throw new FormatException("The input string was in the wrong format.");
            }
            return bakeryProducts.ToArray(); ;
        }
    }
}
