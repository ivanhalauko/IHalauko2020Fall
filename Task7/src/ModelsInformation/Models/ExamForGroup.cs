using ModelsInformation.Interfaces;
using System;
using System.Data.Linq.Mapping;

namespace ModelsInformation.Models
{
    /// <summary>
    /// Class student's exam groupe.
    /// </summary>
    [Table(Name = "ExamForGroup")]
    public class ExamForGroup : ISubstance
    {
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        /// <summary>
        /// Student's examination term ID property.
        /// </summary>
        [Column(Name = "IDExamTerm")]
        public int IDExamTerm { get; set; }

        /// <summary>
        /// Student's exam ID property.
        /// </summary>
        [Column(Name = "IDSubjects")]
        public int IDSubjects { get; set; }

        /// <summary>
        /// Student's groupe ID property.
        /// </summary>
        [Column(Name = "IDGroupe")]
        public int IDGroupe { get; set; }

        /// <summary>
        /// Student's examination date property.
        /// </summary>
        [Column(Name = "DateGroupeExam")]
        public DateTime DateGroupeExam { get; set; }

        /// <summary>
        /// Examiners's ID property.
        /// </summary>
        [Column(Name = "IdExaminers")]
        public int IDExaminers { get; set; }
    }
}
