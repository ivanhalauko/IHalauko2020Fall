using ModelsInformation.Models;
using System.Collections.Generic;

namespace SQLServerView.Interfaces
{
    /// <summary>
    /// Interface with tables contract.
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// Exams tables.
        /// </summary>
        IEnumerable<Exam> Exams { get; }

        /// <summary>
        /// Exams for groups tables.
        /// </summary>
        IEnumerable<ExamForGroup> ExamsForGroups { get; set; }

        /// <summary>
        /// Exam with students results tables.
        /// </summary>
        IEnumerable<ExamStudResults> ExamStudResults { get; }

        /// <summary>
        /// Exams's terms tables.
        /// </summary>
        IEnumerable<ExamTerms> ExamTerms { get; }

        /// <summary>
        /// Groups tables.
        /// </summary>
        IEnumerable<Groups> Groups { get; }

        /// <summary>
        /// Students tables.
        /// </summary>
        IEnumerable<Students> Students { get; }
    }
}
