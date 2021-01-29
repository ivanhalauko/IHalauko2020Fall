using System.Data.Linq.Mapping;
using ModelsInformation.Interfaces;

namespace ModelsInformation.Models
{
    /// <summary>
    /// Student's exam.
    /// </summary>
    [Table(Name = "Subjects")]
    public class Subjects : ISubstance
    {
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        /// <summary>
        /// Student's exam name property.
        /// </summary>
        [Column(Name = "SubjectsName")]
        public string SubjectsName { get; set; }

        /// <summary>
        /// IsAssessment collumn.
        /// </summary>
        [Column(Name = "IsAssessment")]
        public string IsAssessment { get; set; }

        /// <summary>
        /// ExaminersId collumn.
        /// </summary>
        [Column(Name = "IDExaminers")]
        public int IDExaminers { get; set; }
    }
}
