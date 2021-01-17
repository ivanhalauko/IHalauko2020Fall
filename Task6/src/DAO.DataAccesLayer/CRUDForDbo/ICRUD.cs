namespace DAO.DataAccesLayer.CRUDForDbo
{
    /// <summary>
    /// Interface describes CRUD methods.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICRUD<T>
    {
        /// <summary>
        /// Create elements in database.
        /// </summary>
        /// <param name="substance">Object add in database.</param>
        void CreateElement(T substance);

        /// <summary>
        /// Get object by Id from table in database.
        /// </summary>
        /// <param name="byId">Object's id.</param>
        /// <returns>Returns object by id.</returns>
        T ReadElementFromDatabase(int byId);

        /// <summary>
        /// Method to update all objects from database tables.
        /// </summary>
        /// <param name="substance">Object with parameters to be changed.</param>
        /// <returns>Returns changed object.</returns>
        T UpdateDatabase(T substance);

        /// <summary>
        /// Delete object from table by Id.
        /// </summary>
        /// <param name="byId">Object's id.</param>
        void DeleteElement(int byId);
    }
}
