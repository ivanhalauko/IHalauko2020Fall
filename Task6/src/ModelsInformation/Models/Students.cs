using ModelsInformation.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsInformation.Models
{
    [Table("Students")]
    /// <summary>
    /// Student's class.
    /// </summary>
    public class Students : ISubstance
    {
        [Key]
        /// <summary>
        /// Implement interface ISubstance. 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Student's name property.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Student's surname property.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Student's patronymic property.
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Student's birth date property.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Student's groupe ID property.
        /// </summary>
        public int IDGroupe { get; set; }
    }
}
