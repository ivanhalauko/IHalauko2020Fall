using System.Data.Linq.Mapping;
using ModelsInformation.Interfaces;

namespace ModelsInformation.Models
{
    /// <summary>
    /// Student's groupe class.
    /// </summary>
    [Table(Name = "Groups")]
    public class Groups : ISubstance
    {
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        /// <summary>
        /// Student's groupe name property.
        /// </summary>
        [Column(Name = "GroupeName")]
        public string GroupeName { get; set; }

        /// <summary>
        /// SpecialtiesId column in table.
        /// </summary>
        [Column(Name = "IDSpecialties")]
        public int IDSpecialties { get; set; }
    }
}
