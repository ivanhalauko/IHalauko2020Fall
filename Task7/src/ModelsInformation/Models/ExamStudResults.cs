using System.Data.Linq.Mapping;
using ModelsInformation.Interfaces;

namespace ModelsInformation.Models
{
    /// <summary>
    /// Class student's examine results.
    /// </summary>
    [Table(Name = "ExamStudResults")]
    public class ExamStudResults : ISubstance
    {
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        /// <summary>
        /// Student's ID property.
        /// </summary>
        [Column(Name = "IDStudent")]
        public int IDStudent { get; set; }

        /// <summary>
        /// Student's groupe ID property.
        /// </summary>
        [Column(Name = "IDExamForGroupe")]
        public int IDExamForGroupe { get; set; }

        /// <summary>
        /// Student's rating after exam property.
        /// </summary>
        [Column(Name = "Rating")]
        public int Rating { get; set; }
    }
}
