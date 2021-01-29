using System.Data.Linq.Mapping;
using ModelsInformation.Interfaces;

namespace ModelsInformation.Models
{
    /// <summary>
    /// Examination terms.
    /// </summary>
    [Table(Name = "ExamTerms")]
    public class ExamTerms : ISubstance
    {
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Student's exam name property.
        /// </summary>
        [Column(Name = "ExamTermName")]
        public string ExamTermName { get; set; }
    }
}
