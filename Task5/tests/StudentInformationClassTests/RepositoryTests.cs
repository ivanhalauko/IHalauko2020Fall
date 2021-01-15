using NUnit.Framework;
using StudentInformationClass;
using StudentInformationClass.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentInformationClass.Tests
{
    /// <summary>
    /// Class for testing repository.
    /// </summary>
    [TestFixture()]
    class RepositoryTests
    {
        /// <summary>
        /// Given show all tree when order by descending test rating and order by id student then out order descending.
        /// </summary>
        [TestCase]
        public void GivenShowAllTree_WhenOrderByDescendingTestRatingAndOrderByIdStudent_ThenOutOrderDescending()
        {
            //Arrange
            Repository<TestsResult> rep = new Repository<TestsResult>();
            rep.AVLTree.Add(new TestsResult() { Id = 0, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 02, 15), StudentTestRating = 6 });
            rep.AVLTree.Add(new TestsResult() { Id = 1, IdTest = 0, IdStudent = 1, DateOfExams = new System.DateTime(2020, 03, 15), StudentTestRating = 5 });
            rep.AVLTree.Add(new TestsResult() { Id = 2, IdTest = 0, IdStudent = 2, DateOfExams = new System.DateTime(2020, 04, 15), StudentTestRating = 8 });
            rep.AVLTree.Add(new TestsResult() { Id = 3, IdTest = 0, IdStudent = 3, DateOfExams = new System.DateTime(2020, 05, 15), StudentTestRating = 8 });

            List<TestsResult> expectedStudentsResults = new List<TestsResult>()
            {

                new TestsResult() { Id = 2, IdTest = 0, IdStudent = 2, DateOfExams = new System.DateTime(2020, 04, 15), StudentTestRating = 8 },
                new TestsResult() { Id = 3, IdTest = 0, IdStudent = 3, DateOfExams = new System.DateTime(2020, 04, 15), StudentTestRating = 8 },
                new TestsResult() { Id = 0, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 02, 15), StudentTestRating = 6 },
                new TestsResult() { Id = 1, IdTest = 0, IdStudent = 1, DateOfExams = new System.DateTime(2020, 03, 15), StudentTestRating = 5 },
            };

            //Act
            var actualStudentsResults = rep.ShowAllTree().OrderByDescending(x => x.StudentTestRating).ThenBy(y => y.IdStudent);

            //Assert
            Assert.AreEqual(expectedStudentsResults, actualStudentsResults);
        }

        /// <summary>
        /// Given show all tree when order by student results then out order descending.
        /// </summary>
        [TestCase]
        public void GivenShowAllTree_WhenOrderByStudentTestRating_ThenOutOrderDescending()
        {
            //Arrange
            Repository<TestsResult> rep = new Repository<TestsResult>();
            rep.AVLTree.Add(new TestsResult() { Id = 0, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 02, 15), StudentTestRating = 6 });
            rep.AVLTree.Add(new TestsResult() { Id = 1, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 03, 15), StudentTestRating = 5 });
            rep.AVLTree.Add(new TestsResult() { Id = 2, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 04, 15), StudentTestRating = 7 });
            rep.AVLTree.Add(new TestsResult() { Id = 3, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 05, 15), StudentTestRating = 8 });

            List<TestsResult> expectedStudentsResults = new List<TestsResult>()
            {

                new TestsResult() { Id = 3, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 04, 15), StudentTestRating = 8 },
                new TestsResult() { Id = 2, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 04, 15), StudentTestRating = 7 },
                new TestsResult() { Id = 0, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 02, 15), StudentTestRating = 6 },
                new TestsResult() { Id = 1, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 03, 15), StudentTestRating = 5 },
            };

            //Act
            var actualStudentsResults = rep.ShowAllTree().OrderByDescending(x => x.StudentTestRating);
            //Assert
            Assert.AreEqual(expectedStudentsResults, actualStudentsResults);
        }

        /// <summary>
        /// Given show all tree when order by student results then out order.
        /// </summary>
        [TestCase]
        public void GivenShowAllTree_WhenOrderByStudentResults_ThenOutOrder()
        {
            //Arrange
            Repository<TestsResult> rep = new Repository<TestsResult>();
            rep.AVLTree.Add(new TestsResult() { Id = 0, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 02, 15), StudentTestRating = 6 });
            rep.AVLTree.Add(new TestsResult() { Id = 1, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 03, 15), StudentTestRating = 5 });
            rep.AVLTree.Add(new TestsResult() { Id = 2, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 04, 15), StudentTestRating = 7 });
            rep.AVLTree.Add(new TestsResult() { Id = 3, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 05, 15), StudentTestRating = 8 });

            List<TestsResult> expectedStudentsResults = new List<TestsResult>()
            {
                new TestsResult() { Id = 1, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 03, 15), StudentTestRating = 5 },
                new TestsResult() { Id = 0, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 02, 15), StudentTestRating= 6 },
                new TestsResult() { Id = 2, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 04, 15), StudentTestRating = 7 },
                new TestsResult() { Id = 3, IdTest = 0, IdStudent = 0, DateOfExams = new System.DateTime(2020, 04, 15), StudentTestRating = 8 },
            };

            //Act
            var actualStudentsResults = rep.ShowAllTree().OrderBy(x => x.StudentTestRating);
            //Assert
            Assert.AreEqual(expectedStudentsResults, actualStudentsResults);
        }

        /// <summary>
        /// Given show all tree when order by student name then out is ordered.
        /// </summary>
        [TestCase]
        public void GivenShowAllTree_WhenOrderByStudentName_ThenOutIsOrdered()
        {
            //Arrange
            Repository<StudentInfo> rep = new Repository<StudentInfo>();

            rep.AVLTree.Add(new StudentInfo() { Id = 0, StudentName = "Vasya" });
            rep.AVLTree.Add(new StudentInfo() { Id = 1, StudentName = "Petya" });
            rep.AVLTree.Add(new StudentInfo() { Id = 2, StudentName = "YaGor" });

            List<StudentInfo> expectedStudents = new List<StudentInfo>()
            {
                new StudentInfo() { Id = 1, StudentName = "Petya" },
                new StudentInfo() { Id = 0, StudentName = "Vasya" },
                new StudentInfo() { Id = 2, StudentName = "YaGor"}
            };

            //Act   
            var actualStudents = rep.ShowAllTree().OrderBy(x => x.StudentName);
            //Assert
            Assert.AreEqual(expectedStudents, actualStudents);
        }

        /// <summary>
        /// Given show all tree when order descending by student name then out is order descending.
        /// </summary>
        [TestCase]
        public void GivenShowAllTree_WhenOrderDescendingByStudentName_ThenOutIsOrderDescending()
        {
            //Arrange
            Repository<StudentInfo> rep = new Repository<StudentInfo>();

            rep.AVLTree.Add(new StudentInfo() { Id = 0, StudentName = "Vasya" });
            rep.AVLTree.Add(new StudentInfo() { Id = 1, StudentName = "Petya" });
            rep.AVLTree.Add(new StudentInfo() { Id = 2, StudentName = "YaGor" });

            List<StudentInfo> expectedStudents = new List<StudentInfo>()
            {
                new StudentInfo() { Id = 2, StudentName = "YaGor" },
                new StudentInfo() { Id = 0, StudentName = "Vasya" },
                new StudentInfo() { Id = 1, StudentName = "Petya" },
            };

            //Act   
            var actualStudents = rep.ShowAllTree().OrderByDescending(x => x.StudentName);
            //Assert
            Assert.AreEqual(expectedStudents, actualStudents);
        }
    }
}