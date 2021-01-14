using System;

namespace StudentInformationClass
{
    /// <summary>
    /// Class describing students test's results.
    /// </summary>
    [Serializable]
    public class TestsResult : Entity
    {
        /// <summary>
        /// Student's id property.
        /// </summary>
        public int IdStudent { get; set; }

        /// <summary>
        /// Student's id tests property.
        /// </summary>
        public int IdTest { get; set; }

        /// <summary>
        /// Student's tests rating property.
        /// </summary>
        public int StudentTestRating { get; set; }

        /// <summary>
        /// Date of Exams property.
        /// </summary>
        public DateTime DateOfExams { get; set; }
    }
}
