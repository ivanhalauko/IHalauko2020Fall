using NUnit.Framework;
using DAO.DataAccesLayer.CRUDForDbo;
using System;
using ModelsInformation.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataAccesLayer.CRUDForDbo.Tests
{
    [TestFixture()]
    public class ADOTests
    {

        [Test()]
        public void ReadAllExamFromDatabaseByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            ADO<Exam> instance = new ADO<Exam>(connectionString);
            var result = instance.ReadAllElementFromDatabase();

            //Assert.Fail();
        }

        [Test()]
        public void ReadAllExamForGroupFromDatabaseTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            ADO<ExamForGroup> instance = new ADO<ExamForGroup>(connectionString);
            var result = instance.ReadAllElementFromDatabase();

            //Assert.Fail();
        }

        [Test()]
        public void ReadAllExamStudResultsFromDatabaseTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            ADO<ExamStudResults> instance = new ADO<ExamStudResults>(connectionString);
            var result = instance.ReadAllElementFromDatabase();

            //Assert.Fail();
        }


        [Test()]
        public void ReadAllExamTermsFromDatabaseTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            ADO<ExamTerms> instance = new ADO<ExamTerms>(connectionString);
            var result = instance.ReadAllElementFromDatabase();

            //Assert.Fail();
        }

        [Test()]
        public void ReadAllGroupFromDatabaseTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            ADO<Groups> instance = new ADO<Groups>(connectionString);
            var result = instance.ReadAllElementFromDatabase();

            //Assert.Fail();
        }

        [Test()]
        public void ReadAllInformationAboutStudentFromDatabaseTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            ADO<Students> instance = new ADO<Students>(connectionString);
            var result = instance.ReadAllElementFromDatabase();
            //Assert.Fail();
        }

        //TODO: !!!

        [Test()]
        public void DeleteExamByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            int ID = 5;

            Exam exam = new Exam() { Id = ID, ExamName = "TestsById" };
            ADO<Exam> instanceExam = new ADO<Exam>(connectionString);
            instanceExam.CreateElement(exam);

            ADO<Exam> instance = new ADO<Exam>(connectionString);
            instance.DeleteElement(ID);
            //Assert.Fail();
        }

        [Test()]
        public void DeleteExamForGroupByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            int Id = 1004;
            ADO<ExamForGroup> instance = new ADO<ExamForGroup>(connectionString);
            instance.DeleteElement(Id);
            //Assert.Fail();
        }

        [Test()]
        public void DeleteExamStudResultsByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            int Id = 1009;
            ADO<ExamStudResults> instance = new ADO<ExamStudResults>(connectionString);
            instance.DeleteElement(Id);
            //Assert.Fail();
        }

        [Test()]
        public void DeleteExamTermsByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            int Id = 1011;
            ADO<ExamTerms> instance = new ADO<ExamTerms>(connectionString);
            instance.DeleteElement(Id);
            //Assert.Fail();
        }

        [Test()]
        public void DeleteGroupeByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            int Id = 6;
            ADO<Groups> instance = new ADO<Groups>(connectionString);
            instance.DeleteElement(Id);
        }

        [Test()]
        public void DeleteStudentByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            int Id = 8;
            ADO<Students> instance = new ADO<Students>(connectionString);
            instance.DeleteElement(Id);
        }
        [Test()]
        public void UpdateExamTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            Exam exam = new Exam() { Id = 2, ExamName = "Phisics" };
            ADO<Exam> instanceExam = new ADO<Exam>(connectionString);
            instanceExam.UpdateDatabase(exam);

            //Assert.Fail();
        }
        [Test()]
        public void UpdateExamForGroupTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            DateTime dateGroupeExam = new DateTime(2016, 1, 1, 1, 1, 1);
            ExamForGroup exam = new ExamForGroup() { Id = 1, IDExam = 3, IDGroupe = 1, IDExamTerm = 1, DateGroupeExam = dateGroupeExam };
            ADO<ExamForGroup> instanceExamTerms = new ADO<ExamForGroup>(connectionString);
            instanceExamTerms.UpdateDatabase(exam);
            //Assert.Fail();
        }
        [Test()]
        public void UpdateExamStudentResultTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            ExamStudResults student = new ExamStudResults() { Id = 1, IDExamForGroupe = 1, IDStudent = 1, Rating = 1 };
            ADO<ExamStudResults> instance = new ADO<ExamStudResults>(connectionString);
            //instance.CreateElement(student);
            instance.UpdateDatabase(student);
            //Assert.Fail();
        }

        [Test()]
        public void UpdateExamTermsTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            ExamTerms student = new ExamTerms() { Id = 1, ExamTermName = "Army" };
            ADO<ExamTerms> instance = new ADO<ExamTerms>(connectionString);
            //instance.CreateElement(student);
            instance.UpdateDatabase(student);
            //Assert.Fail();
        }

        [Test()]
        public void UpdateGroupsTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            Groups student = new Groups() { Id = 1, GroupeName = "TOO" };
            ADO<Groups> instance = new ADO<Groups>(connectionString);
            //instance.CreateElement(student);
            instance.UpdateDatabase(student);
            //Assert.Fail();
        }

        [Test()]
        public void UpdateStudentTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            DateTime birth = new DateTime(2015, 10, 5, 3, 4, 5);
            Students student = new Students() { Id = 1, Name = "Vasya", Surname = "Ivanov", Patronymic = "NEW", BirthDate = birth, IDGroupe = 1 };
            ADO<Students> instance = new ADO<Students>(connectionString);
            instance.UpdateDatabase(student);

            //Assert.Fail();
        }

        [Test()]
        public void ReadExamFromDatabaseByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            int Id = 1;
            ADO<Exam> instance = new ADO<Exam>(connectionString);
            var result = instance.ReadElementFromDatabase(Id);

            //Assert.Fail();
        }

        [Test()]
        public void ReadExamForGroupFromDatabaseByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            int Id = 1;
            ADO<ExamForGroup> instance = new ADO<ExamForGroup>(connectionString);
            var result = instance.ReadElementFromDatabase(Id);

            //Assert.Fail();
        }

        [Test()]
        public void ReadExamStudResultsFromDatabaseByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            int Id = 1;
            ADO<ExamStudResults> instance = new ADO<ExamStudResults>(connectionString);
            var result = instance.ReadElementFromDatabase(Id);

            //Assert.Fail();
        }


        [Test()]
        public void ReadExamTermsFromDatabaseByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            int Id = 1;
            ADO<ExamTerms> instance = new ADO<ExamTerms>(connectionString);
            var result = instance.ReadElementFromDatabase(Id);

            //Assert.Fail();
        }

        [Test()]
        public void ReadGroupFromDatabaseByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            int Id = 1;
            ADO<Groups> instance = new ADO<Groups>(connectionString);
            var result = instance.ReadElementFromDatabase(Id);

            //Assert.Fail();
        }

        [Test()]
        public void ReadInformationAboutStudentFromDatabaseByIdTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            int Id = 1;
            ADO<Students> instance = new ADO<Students>(connectionString);
            var result = instance.ReadElementFromDatabase(Id);
            //Assert.Fail();
        }


        [Test()]
        public void CreateExamTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            Exam exam = new Exam() { ExamName = "Phisics" };
            ADO<Exam> instanceExam = new ADO<Exam>(connectionString);
            instanceExam.CreateElement(exam);

            //Assert.Fail();
        }

        [Test()]
        public void CreateExamStudResultTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            ExamStudResults exam = new ExamStudResults() { IDStudent = 1, IDExamForGroupe = 1, Rating = 8 };
            ADO<ExamStudResults> instanceExamTerms = new ADO<ExamStudResults>(connectionString);
            instanceExamTerms.CreateElement(exam);

            //Assert.Fail();
        }

        [Test()]
        public void CreateExamForGroupTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DateTime dateGroupeExam = new DateTime(2015, 10, 5, 3, 4, 5);
            ExamForGroup exam = new ExamForGroup() { IDExam = 1, IDGroupe = 1, IDExamTerm = 1, DateGroupeExam = dateGroupeExam };
            ADO<ExamForGroup> instanceExamTerms = new ADO<ExamForGroup>(connectionString);
            instanceExamTerms.CreateElement(exam);

            //Assert.Fail();
        }

        [Test()]
        public void CreateExamTermsTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            ExamTerms examTerms = new ExamTerms() { ExamTermName = "Finised" };
            ADO<ExamTerms> instanceExam = new ADO<ExamTerms>(connectionString);
            instanceExam.CreateElement(examTerms);

            //Assert.Fail();
        }

        [Test()]
        public void CreateGroupeTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            Groups groupe = new Groups() { GroupeName = "ER" };
            ADO<Groups> instanceGroupe = new ADO<Groups>(connectionString);
            instanceGroupe.CreateElement(groupe);

            //Assert.Fail();
        }

        [Test()]
        public void CreateStudentTest()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLServer.Database;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            DateTime birth = new DateTime(2015, 10, 5, 3, 4, 5);
            Students student = new Students() { Name = "Vasya", Surname = "Ivanov", Patronymic = "Petrovich", BirthDate = birth, IDGroupe = 1 };
            ADO<Students> instance = new ADO<Students>(connectionString);
            instance.CreateElement(student);

            //Assert.Fail();
        }
    }
}