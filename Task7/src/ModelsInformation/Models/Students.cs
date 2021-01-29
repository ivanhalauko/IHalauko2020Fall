using System.Data.Linq.Mapping;
using ModelsInformation.Interfaces;

namespace ModelsInformation.Models
{
    /// <summary>
    /// Student's class.
    /// </summary>
    [Table(Name = "Students")]
    public class Students : ISubstance
    {
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        /// <summary>
        /// Student's name property.
        /// </summary>
        [Column(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Student's surname property.
        /// </summary>
        [Column(Name = "Surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Student's patronymic property.
        /// </summary>
        [Column(Name = "Patronymic")]
        public string Patronymic { get; set; }

        /// <summary>
        /// Student's birth date property.
        /// </summary>
        [Column(Name = "BirthDate")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Student's groupe ID property.
        /// </summary>
        [Column(Name = "IDGroupe")]
        public int IDGroupe { get; set; }
    }
}
