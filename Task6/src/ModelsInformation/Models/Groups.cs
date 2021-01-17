using ModelsInformation.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation.Models
{
    [Table("Groups")]
    /// <summary>
    /// Student's groupe class.
    /// </summary>
    public class Groups : ISubstance
    {
        [Key]
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Student's groupe name property.
        /// </summary>
        public string GroupeName { get; set; }
    }
}
