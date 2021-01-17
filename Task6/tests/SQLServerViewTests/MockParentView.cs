using ModelsInformation.Models;
using Moq;
using NUnit.Framework;
using SQLServerView.Interfaces;
using System;
using System.Collections.Generic;

namespace SQLServerViewTests
{
    /// <summary>
    /// Class for tests.
    /// </summary>

    public class MockParentView
    {
        /// <summary>
        /// Exam for group tables.
        /// </summary>
        public IEnumerable<ExamForGroup> ExamForGroup { get; set; }

        /// <summary>
        /// Groups tables.
        /// </summary>
        public IEnumerable<Groups> Groups { get; set; }

        /// <summary>
        /// Exams's terms tables.
        /// </summary>
        IEnumerable<ExamTerms> ExamTerms { get; set; }

        /// <summary>
        /// Exam students results tables.
        /// </summary>
        IEnumerable<ExamStudResults> ExamStudResults { get; set; }

        /// <summary>
        /// Students tables.
        /// </summary>
        IEnumerable<Students> Students { get; set; }

        /// <summary>
        /// Exams tables.
        /// </summary>
        IEnumerable<Exam> Exams { get; set; }

        /// <summary>
        /// Mock property.
        /// </summary>
        public Mock<IView> Mock { get; set; }

        /// <summary>
        /// Mock method.
        /// </summary>
        [SetUp]
        public void InitialMock()
        {
            ExamForGroup = new List<ExamForGroup>()
            {
                new ExamForGroup() {Id = 1, IDExamTerm = 1, IDGroupe= 1, IDExam = 1, DateGroupeExam = new DateTime( 2020,07, 28, 13, 03,24)},
                new ExamForGroup() {Id = 2, IDExamTerm = 1, IDGroupe= 2, IDExam = 2, DateGroupeExam = new DateTime( 2020,06, 27, 13, 03,24)},
                new ExamForGroup() {Id = 3, IDExamTerm = 1, IDGroupe= 1, IDExam = 3, DateGroupeExam = new DateTime( 2020,04, 26, 13, 03,24)},
                new ExamForGroup() {Id = 4, IDExamTerm = 1, IDGroupe= 2, IDExam = 4, DateGroupeExam = new DateTime( 2020,05, 25, 13, 03,24)},
                new ExamForGroup() {Id = 5, IDExamTerm = 2, IDGroupe= 1, IDExam = 1, DateGroupeExam = new DateTime( 2020,06, 24, 13, 03,24)},
                new ExamForGroup() {Id = 6, IDExamTerm = 2, IDGroupe= 2, IDExam = 2, DateGroupeExam = new DateTime( 2020,03, 23, 13, 03,24)},
                new ExamForGroup() {Id = 7, IDExamTerm = 2, IDGroupe= 1, IDExam = 3, DateGroupeExam = new DateTime( 2020,02, 22, 13, 03,24)},
            };

            Groups = new List<Groups>()
            {
                new Groups(){Id=1, GroupeName="RF"},
                new Groups(){Id=2, GroupeName="TM"}
            };

            ExamTerms = new List<ExamTerms>
            {
                new ExamTerms(){Id=1,ExamTermName="First"},
                new ExamTerms(){Id=2,ExamTermName="Second"}
            };

            ExamStudResults = new List<ExamStudResults>
            {
                new ExamStudResults(){Id=1, IDStudent=1, IDExamForGroupe=1, Rating=4},
                new ExamStudResults(){Id=2, IDStudent=1, IDExamForGroupe=2, Rating=5},
                new ExamStudResults(){Id=3, IDStudent=1, IDExamForGroupe=3, Rating=6},
                new ExamStudResults(){Id=4, IDStudent=2, IDExamForGroupe=4, Rating=7},
                new ExamStudResults(){Id=5, IDStudent=2, IDExamForGroupe=5, Rating=8},
                new ExamStudResults(){Id=6, IDStudent=2, IDExamForGroupe=6, Rating=9},
                new ExamStudResults(){Id=7, IDStudent=3, IDExamForGroupe=7, Rating=10},
                new ExamStudResults(){Id=8, IDStudent=3, IDExamForGroupe=1, Rating=4},
                new ExamStudResults(){Id=9, IDStudent=3, IDExamForGroupe=2, Rating=5},
                new ExamStudResults(){Id=10, IDStudent=4, IDExamForGroupe=3, Rating=6},
                new ExamStudResults(){Id=11, IDStudent=4, IDExamForGroupe=4, Rating=7},
                new ExamStudResults(){Id=12, IDStudent=4, IDExamForGroupe=5, Rating=8},
                new ExamStudResults(){Id=13, IDStudent=4, IDExamForGroupe=6, Rating=9},
                new ExamStudResults(){Id=14, IDStudent=5, IDExamForGroupe=7, Rating=10},
            };

            Students = new List<Students>
            {
                new Students(){Id=1, Name="Name1", Surname="Surname1", Patronymic="Patronomic1",BirthDate=new DateTime(2020,07,20), IDGroupe=1 },
                new Students(){Id=2, Name="Name2", Surname="Surname2", Patronymic="Patronomic2",BirthDate=new DateTime(2020,07,20), IDGroupe=2 },
                new Students(){Id=3, Name="Name3", Surname="Surname3", Patronymic="Patronomic3",BirthDate=new DateTime(2020,07,20), IDGroupe=1 },
                new Students(){Id=4, Name="Name4", Surname="Surname4", Patronymic="Patronomic4",BirthDate=new DateTime(2020,07,20), IDGroupe=2 },
                new Students(){Id=5, Name="Name5", Surname="Surname5", Patronymic="Patronomic5",BirthDate=new DateTime(2020,07,20), IDGroupe=1 },
                new Students(){Id=6, Name="Name6", Surname="Surname6", Patronymic="Patronomic6",BirthDate=new DateTime(2020,07,20), IDGroupe=2 },
                new Students(){Id=7, Name="Name7", Surname="Surname7", Patronymic="Patronomic7",BirthDate=new DateTime(2020,07,20), IDGroupe=1 },
                new Students(){Id=8, Name="Name8", Surname="Surname8", Patronymic="Patronomic8",BirthDate=new DateTime(2020,07,20), IDGroupe=2 },
                new Students(){Id=9, Name="Name9", Surname="Surname9", Patronymic="Patronomic9",BirthDate=new DateTime(2020,07,20), IDGroupe=1 },
            };
            Exams = new List<Exam>()
            {
                new Exam(){Id=1,ExamName="Phisic"},
                new Exam(){Id=2,ExamName="Philosophy"},
                new Exam(){Id=3,ExamName="Math"},
                new Exam(){Id=4,ExamName="Chemistry"},
                new Exam(){Id=5,ExamName="Language"},
                new Exam(){Id=6,ExamName="Astronomy"}
            };
            Mock = new Mock<IView>();
            Mock.Setup(x => x.Exams).Returns(Exams);
            Mock.Setup(x => x.Groups).Returns(Groups);
            Mock.Setup(x => x.ExamsForGroups).Returns(ExamForGroup);
            Mock.Setup(x => x.ExamStudResults).Returns(ExamStudResults);
            Mock.Setup(x => x.ExamTerms).Returns(ExamTerms);
            Mock.Setup(x => x.Exams).Returns(Exams);
        }
    }
}
