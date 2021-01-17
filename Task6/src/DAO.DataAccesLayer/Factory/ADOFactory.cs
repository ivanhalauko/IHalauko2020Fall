using DAO.DataAccesLayer.CRUDForDbo;
using ModelsInformation;
using ModelsInformation.Models;

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
        protected internal ADO<Exam> Exam { get; set; }
        /// <summary>
        /// Represent access to ExamForGroup table.
        /// </summary>
        protected internal ADO<ExamForGroup> ExamForGroup { get; set; }
        /// <summary>
        /// Represent access to ExamStudResults table.
        /// </summary>
        protected internal ADO<ExamStudResults> ExamStudResults { get; set; }
        /// <summary>
        /// Represent access to ExamTerms table.
        /// </summary>
        protected internal ADO<ExamTerms> ExamTerms { get; set; }
        /// <summary>
        /// Represent access to Groups table.
        /// </summary>
        protected internal ADO<Groups> Groups { get; set; }
        /// <summary>
        /// Represent access to Students table.
        /// </summary>
        protected internal ADO<Students> Students { get; set; }
        /// <summary>
        /// Constructor to initializing access with tables and get connection string to database.
        /// </summary>
        /// <param name="dbConnectionString"></param>
        public ADOFactory(string dbConnectionString)
        {
            Exam = new ADO<Exam>(dbConnectionString);
            ExamForGroup = new ADO<ExamForGroup>(dbConnectionString);
            ExamStudResults = new ADO<ExamStudResults>(dbConnectionString);
            ExamTerms = new ADO<ExamTerms>(dbConnectionString);
            Groups = new ADO<Groups>(dbConnectionString);
            Students = new ADO<Students>(dbConnectionString);
        }
        /// <summary>
        /// Factory method to create Exam table.
        /// </summary>
        /// <returns></returns>
        public override ICRUD<Exam> CreateExam()
        {
            return Exam;
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
    }
}
