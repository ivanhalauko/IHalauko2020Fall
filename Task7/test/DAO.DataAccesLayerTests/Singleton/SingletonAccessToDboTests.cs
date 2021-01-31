using NUnit.Framework;

namespace DAO.DataAccesLayer.Singleton.Tests
{
	[TestFixture()]
	public class SingletonAccessToDboTests
	{

        /// <summary>
        /// Checkin to create instance.
        /// </summary>
        /// <param name="expectedIsInstanceCreate">Is instance created?</param>
        [TestCase(true)]
        public void GivenGetInstance_ThenOutIsNotNullInstance(bool expectedIsInstanceCreate)
        {
            //Arrange
            string _dbConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database.Task7;Integrated Security = True; Connect Timeout=30 ; Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout = 60; Encrypt=False;TrustServerCertificate=True"; ;
        SingletonAccessToDbo singleton = SingletonAccessToDbo.GetInstance(_dbConnectionString);
            var actualIsInstanceCreate = false;
            //Act
            if (singleton.Factory != null)
                actualIsInstanceCreate = true;
            //Assert
            Assert.AreEqual(expectedIsInstanceCreate, actualIsInstanceCreate);
        }
    }
}