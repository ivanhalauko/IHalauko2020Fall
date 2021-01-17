using DAO.DataAccesLayer.CRUDForDbo;
using ModelsInformation;
using ModelsInformation.Models;

namespace DAO.DataAccesLayer.Factory
{
    /// <summary>
    /// Abstract factory to get access to database tables.
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// Create Students abstract method.
        /// </summary>
        /// <returns></returns>
        public abstract ICRUD<Students> CreateStudents();

        /// <summary>
        /// Create Groups abstract method.
        /// </summary>
        /// <returns></returns>
        public abstract ICRUD<Groups> CreateGroups();

        /// <summary>
        /// Create ExamTerms abstract method.
        /// </summary>
        /// <returns></returns>
        public abstract ICRUD<ExamTerms> CreateExamTerms();

        /// <summary>
        /// Create ExamStudResults abstract method.
        /// </summary>
        /// <returns></returns>
        public abstract ICRUD<ExamStudResults> CreateExamStudResults();

        /// <summary>
        /// Create ExamForGroup abstract method.
        /// </summary>
        /// <returns></returns>
        public abstract ICRUD<ExamForGroup> CreateExamForGroup();

        /// <summary>
        /// Create Exam abstract method.
        /// </summary>
        /// <returns></returns>
        public abstract ICRUD<Exam> CreateExam();
    }
}
