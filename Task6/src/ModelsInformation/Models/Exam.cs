using ModelsInformation.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation.Models
{
    [Table("Exam")]
    /// <summary>
    /// Student's exam.
    /// </summary>
    public class Exam : ISubstance
    {
        [Key]
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Student's exam name property.
        /// </summary>
        public string ExamName { get; set; }
    }
}
