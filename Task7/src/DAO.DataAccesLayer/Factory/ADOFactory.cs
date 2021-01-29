using DAO.DataAccesLayer.CRUDForDbo;
using ModelsInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataAccesLayer.Factory
{
    /// <summary>
    /// ADO factory class.
    /// </summary>
    public class ADOFactory : AbstractFactory
    {
        /// <summary>
        /// Represent access to Exam table.
        /// </summary>
        protected internal ADOLinqToSQL<Subjects> Subjects { get; set; }
        /// <summary>
        /// Represent access to ExamForGroup table.
        /// </summary>
        protected internal ADOLinqToSQL<ExamForGroup> ExamForGroup { get; set; }
        /// <summary>
        /// Represent access to ExamStudResults table.
        /// </summary>
        protected internal ADOLinqToSQL<ExamStudResults> ExamStudResults { get; set; }
        /// <summary>
        /// Represent access to ExamTerms table.
        /// </summary>
        protected internal ADOLinqToSQL<ExamTerms> ExamTerms { get; set; }
        /// <summary>
        /// Represent access to Groups table.
        /// </summary>
        protected internal ADOLinqToSQL<Groups> Groups { get; set; }
        /// <summary>
        /// Represent access to Students table.
        /// </summary>
        protected internal ADOLinqToSQL<Students> Students { get; set; }
        /// <summary>
        /// Represent access to Examiners table.
        /// </summary>
        protected internal ADOLinqToSQL<Examiners> Examiners { get; set; }

        /// <summary>
        /// Constructor to initializing access with tables and get connection string to database.
        /// </summary>
        /// <param name="dbConnectionString"></param>
        public ADOFactory(string dbConnectionString)
        {
            Subjects = new ADOLinqToSQL<Subjects>(dbConnectionString);
            ExamForGroup = new ADOLinqToSQL<ExamForGroup>(dbConnectionString);
            ExamStudResults = new ADOLinqToSQL<ExamStudResults>(dbConnectionString);
            ExamTerms = new ADOLinqToSQL<ExamTerms>(dbConnectionString);
            Groups = new ADOLinqToSQL<Groups>(dbConnectionString);
            Students = new ADOLinqToSQL<Students>(dbConnectionString);
        }
        /// <summary>
        /// Factory method to create Exam table.
        /// </summary>
        /// <returns></returns>
        public override ICRUD<Subjects> CreateSubjects()
        {
            return Subjects;
        }
        /// <summary>
        /// Factory method to create ExamForGroup table.
        /// </summary>
        /// <returns></returns>
        public override ICRUD<ExamForGroup> CreateExamForGroup()
        {
            return ExamForGroup;
        }
        /// <summary>
        /// Factory method to create ExamStudResults table.
        /// </summary>
        /// <returns></returns>
        public override ICRUD<ExamStudResults> CreateExamStudResults()
        {
            return ExamStudResults;
        }
        /// <summary>
        /// Factory method to create ExamTerms table.
        /// </summary>
        /// <returns></returns>
        public override ICRUD<ExamTerms> CreateExamTerms()
        {
            return ExamTerms;
        }
        /// <summary>
        /// Factory method to create Groups table.
        /// </summary>
        /// <returns></returns>
        public override ICRUD<Groups> CreateGroups()
        {
            return Groups;
        }
        /// <summary>
        /// Factory method to create Students table.
        /// </summary>
        /// <returns></returns>
        public override ICRUD<Students> CreateStudents()
        {
            return Students;
        }
        /// <summary>
        /// Factory method to create Examiners table.
        /// </summary>
        /// <returns></returns>
        public override ICRUD<Examiners> CreateExaminers()
        {
            return Examiners;
        }
    }
}
