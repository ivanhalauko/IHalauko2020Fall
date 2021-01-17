using DAO.DataAccesLayer.Factory;

namespace DAO.DataAccesLayer.Singleton
{
    /// <summary>
    /// Access class to database.
    /// </summary>
    public class SingletonAccessToDbo
    {
        /// <summary>
        /// Field _instance.
        /// </summary>
        private static SingletonAccessToDbo _instance = null;
        /// <summary>
        /// Property Factory.
        /// </summary>
        public AbstractFactory Factory { get; set; } = null;
        /// <summary>
        /// Constuctor with parameters.
        /// </summary>
        /// <param name="factory">Return Factory field.</param>
        private SingletonAccessToDbo(AbstractFactory factory)
        {
            AbstractFactory Factory = factory;
        }
        /// <summary>
        /// Method to create _instance.
        /// </summary>
        /// <param name="factory">Input database factory.</param>
        /// <returns>Singleton instance.</returns>
        public static SingletonAccessToDbo GetInstance(AbstractFactory factory)
        {
            if (_instance == null)
            {
                _instance = new SingletonAccessToDbo(factory);
            }
            return _instance;
        }
    }
}
