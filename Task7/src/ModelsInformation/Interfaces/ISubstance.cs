using System.Data.Linq.Mapping;

namespace ModelsInformation.Interfaces
{
    /// <summary>
    /// Interface substances class.
    /// </summary>
    public interface ISubstance
    {
        /// <summary>
        /// Property interfaces's Id.
        /// </summary>
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        int Id { get; set; }
    }
}
