using NUnit.Framework;
using DAO.DataAccesLayer.CRUDForDbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsInformation.Models;

namespace DAO.DataAccesLayer.CRUDForDbo.Tests
{
    /// <summary>
    /// Test class for testing CRUD (LINQ to SQL) methods.
    /// </summary>
    [TestFixture()]
    public class ADOLinqToSQLTests
    {
        /// <summary>
        /// Field with group repository.
        /// </summary>
        private ICRUD<Specialties> specialties;

        private ICRUD<Examiners> examiners;

        /// <summary>
        /// Private field connection string. 
        /// </summary>
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database.Task7;Integrated Security = True; Connect Timeout=30 ; Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout = 60; Encrypt=False;TrustServerCertificate=True";

        /// <summary>
        /// Test cases for Add, Read and Delete CRUD-methods.
        /// </summary>
        /// <param name="actualName">Parameter's name.</param>
        [TestCase("Sailor", "Intresting conditions of work")]
        [TestCase("AncientSpecialities", "Bad conditions of work")]
        [TestCase("NewModernSpecialities", "Good conditions of work")]
        public void ReadAllAndAddAndDelete_ThenOutIsActualNameOfSpecialtiesTable(string actualName, string infoOfSpecialty)
        {
            //Arrage
            Specialties actual = new Specialties() { Id = 5, NameOfSpecialty = actualName, InfoOfSpecialty = infoOfSpecialty };
            //Act
            specialties = new ADOLinqToSQL<Specialties>(connectionString);
            specialties.CreateElement(actual);

            var lastAddedName = specialties.ReadAllElementFromDatabase().ToList().Last().NameOfSpecialty;
            var lastAddedId = specialties.ReadAllElementFromDatabase().ToList().Last().Id;
            specialties.DeleteElement(lastAddedId);
            //Assert
            Assert.AreEqual(lastAddedName, actualName);
        }

        /// <summary>
        /// Test cases for Update CRUD-method.
        /// </summary>
        /// <param name="name">Name of object's field.</param>
        /// <param name="actualUpdateName">Actual update name.</param>
        [TestCase("NameSpecialityeTest1", "NewNameSpecialityTest1")]
        [TestCase("NameSpecialityeTest2", "NewNameSpecialityTest2")]
        [TestCase("NameSpecialityeTest3", "NewNameSpecialityTest3")]
        public void GivenUpdate_WhenAdded_ThenOutUpdateName_ThisSpecialtiesTable(string name, string actualUpdateName)
        {
            //Arrage
            Specialties actual = new Specialties() { NameOfSpecialty = name };
            //Act
            specialties = new ADOLinqToSQL<Specialties>(connectionString);
            specialties.CreateElement(actual);
            var lastAddedId = specialties.ReadAllElementFromDatabase().ToList().Last().Id;
            specialties.UpdateDatabase(new Specialties() { Id = lastAddedId, NameOfSpecialty = actualUpdateName });
            var expectedUpdetedName = specialties.ReadElementFromDatabase(lastAddedId);
            specialties.DeleteElement(lastAddedId); //clear last addded element
            //Assert
            Assert.AreEqual(expectedUpdetedName.NameOfSpecialty, actualUpdateName);
        }

        /// <summary>
        /// Test cases for Add, Read and Delete CRUD-methods.
        /// </summary>
        /// <param name="id">Id of Examiners.</param>
        /// <param name="name">Name of Examiners.</param>
        /// <param name="surname">Surname of Examiners.</param>
        /// <param name="patronymic">Patronymic of Examiners.</param>
        [TestCase(10, "Ivan", "Ivanovich", "Ivanov")]
        [TestCase(10, "Grigoriy", "Grigorievich", "Grigoriev")]
        [TestCase(10, "Petr", "Petrovich", "Petrov")]
        public void ReadAllAndAddAndDelete_ThenOutIsActualNameOfExaminersTable(int id, string actualName, string surname, string patronymic)
        {
            //Arrage
            Examiners actual = new Examiners() { Id = id, Name = actualName, Surname = surname, Patronymic = patronymic };
            //Act
            examiners = new ADOLinqToSQL<Examiners>(connectionString);
            examiners.CreateElement(actual);

            var lastAddedName = examiners.ReadAllElementFromDatabase().ToList().Last().Name;
            var lastAddedId = examiners.ReadAllElementFromDatabase().ToList().Last().Id;
            examiners.DeleteElement(lastAddedId);
            //Assert
            Assert.AreEqual(lastAddedName, actualName);
        }

        /// <summary>
        /// Test cases for Update CRUD-method.
        /// </summary>
        /// <param name="name">Name of object's field.</param>
        /// <param name="actualUpdateName">Actual update name.</param>
        //[TestCase("NameSpecialityeTest1", "NewNameSpecialityTest1")]
        //[TestCase("NameSpecialityeTest2", "NewNameSpecialityTest2")]
        [TestCase("Ivan", "Ivanovich", "Ivanov", "Grigoriy")]
        [TestCase("Grigoriy", "Grigorievich", "Grigoriev", "Grigoriy")]
        [TestCase("Petr", "Petrovich", "Petrov", "Grigoriy")]
        public void GivenUpdate_WhenAdded_ThenOutUpdateName_ThisExaminersTable(string name, string surname, string patronymic, string actualUpdateName)
        {
            //Arrage
            Examiners actual = new Examiners() { Name = name, Surname = surname, Patronymic = patronymic };
            //Act
            examiners = new ADOLinqToSQL<Examiners>(connectionString);
            examiners.CreateElement(actual);

            var lastAddedId = examiners.ReadAllElementFromDatabase().ToList().Last().Id;
            examiners.UpdateDatabase(new Examiners() { Id = lastAddedId, Name = actualUpdateName, Surname = surname, Patronymic = patronymic });
            var expectedUpdetedName = examiners.ReadElementFromDatabase(lastAddedId);
            examiners.DeleteElement(lastAddedId); //clear last addded element
            //Assert
            Assert.AreEqual(expectedUpdetedName.Name, actualUpdateName);
        }
    }
}