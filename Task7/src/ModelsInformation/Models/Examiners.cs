using ModelsInformation.Interfaces;
using System.Data.Linq.Mapping;

namespace ModelsInformation.Models
{
    /// <summary>
    /// Examiner's class.
    /// </summary>
    [Table(Name = "Examiners")]
    public class Examiners : ISubstance
    {
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        /// <summary>
        /// Examiner's name property.
        /// </summary>
        [Column(Name = "Name")]
        public string Name { get; set; }
        /// <summary>
        /// Examiner's surname property.
        /// </summary>
        [Column(Name = "Surname")]
        public string Surname { get; set; }
        /// <summary>
        /// Examiner's patronymic property.
        /// </summary>
        [Column(Name = "Patronymic")]
        public string Patronymic { get; set; }
    }
}
