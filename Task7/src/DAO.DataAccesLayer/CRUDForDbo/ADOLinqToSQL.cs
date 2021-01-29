using System;
using System.Collections.Generic;
using System.Data.Linq;
using ModelsInformation.Interfaces;
using System.Linq;
using System.Reflection;
using System.Data;

namespace DAO.DataAccesLayer.CRUDForDbo
{
    /// <summary>
    /// Class with implemented CRUD methods.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ADOLinqToSQL<T> : ICRUD<T> where T : class, ISubstance, new()
    {
        /// <summary>
        /// Connection string to database
        /// </summary>
        protected DataContext DataContext { get; private set; }
        /// <summary>
        /// Constructor with parameter.
        /// </summary>
        /// <param name="connectionString"></param>
        public ADOLinqToSQL(string connectionString)
        {
            DataContext = new DataContext(connectionString)
            {
                DeferredLoadingEnabled = false
            };
        }
        /// <summary>
        /// Create element and add to data base.
        /// </summary>
        /// <param name="substance">Object type of T.</param>
        public void CreateElement(T substance)
        {
            if (substance == null)
                throw new ArgumentNullException(typeof(T).Name + "object Should not be Null when Saving to database");
            DataContext.GetTable<T>().InsertOnSubmit(substance);
            DataContext.SubmitChanges();
        }
        /// <summary>
        /// Delete element from data base.
        /// </summary>
        /// <param name="byId">Element's Id.</param>
        public void DeleteElement(int byId)
        {
            if (byId == 0) throw new ArgumentNullException("byId should not be 0");

            DataContext.GetTable<T>().DeleteOnSubmit(DataContext.GetTable<T>().Where(x => x.Id.Equals(byId)).SingleOrDefault());
            DataContext.SubmitChanges();
        }
        /// <summary>
        /// Read all elements from database.
        /// </summary>
        /// <returns>Return elements from data base.</returns>
        public IEnumerable<T> ReadAllElementFromDatabase()
        {
            return DataContext.GetTable<T>();
        }
        /// <summary>
        /// Read all elements from database.
        /// </summary>
        /// <param name="byId">Element's Id.</param>
        /// <returns>Return element from data base.</returns>
        public T ReadElementFromDatabase(int byId)
        {
            if (byId == 0) throw new ArgumentNullException("byId should not be 0");

            return DataContext.GetTable<T>().Where(x => x.Id.Equals(byId)).SingleOrDefault();

        }

        /// <summary>
        /// Method to convert table to IEnumerable<T>.
        /// </summary>
        /// <param name="table">Input table.</param>
        /// <returns>Return of table.</returns>
        public IEnumerable<T> ToEnumerable(DataTable table)
        {
            List<T> list = new List<T>();
            foreach (var row in table.AsEnumerable())
            {
                T obj = new T();
                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                    }
                    catch
                    {
                        continue;
                    }
                }
                list.Add(obj);
            }
            return list;
        }
        /// <summary>
        /// Update all elements in database.
        /// </summary>
        /// <param name="substance">Substance with new data.</param>
        /// <returns>Returns updated element.</returns>
        public T UpdateDatabase(T substance)
        {
            if (substance == null) throw new ArgumentNullException();

            var tableElement = DataContext.GetTable<T>().Where(x => x.Id.Equals(substance.Id)).SingleOrDefault();
            var updatedTableElement = GetUpdateParameter(substance, tableElement);
            DataContext.SubmitChanges();
            return updatedTableElement;
        }

        /// <summary>
        /// Updata fields from one object to other.
        /// </summary>
        /// <param name="from">Main object.</param>
        /// <param name="to">Target object.</param>
        /// <returns>Returns updated object.</returns>
        private T GetUpdateParameter(T from, T to)
        {
            if (from == null) throw new ArgumentNullException();
            if (to == null) throw new ArgumentNullException();

            PropertyInfo[] fieldsTo = to.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo[] fieldsFrom = from.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var fTo in fieldsTo)
            {
                foreach (var fFrom in fieldsFrom)
                {
                    if (fTo.Name == fFrom.Name)
                    {
                        fTo.SetValue(to, fFrom.GetValue(from));
                        break;
                    }
                }
            }
            return to;
        }

    }
}
