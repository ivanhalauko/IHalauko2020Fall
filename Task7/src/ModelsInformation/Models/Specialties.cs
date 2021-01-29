using System.Data.Linq.Mapping;
using ModelsInformation.Interfaces;

namespace ModelsInformation.Models
{
    /// <summary>
    /// Specialtie's class.
    /// </summary>
    [Table(Name = "Specialties")]
    public class Specialties : ISubstance
    {
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
		/// Name column in table.
		/// </summary>
        [Column(Name = "NameOfSpecialty")]
        public string NameOfSpecialty { get; set; }

        /// <summary>
        /// Info column in table. 
        /// </summary>
        [Column(Name = "InfoOfSpecialty")]
        public string InfoOfSpecialty { get; set; }
    }
}
