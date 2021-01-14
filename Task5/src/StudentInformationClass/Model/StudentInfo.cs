using System;

namespace StudentInformationClass
{
    /// <summary>
    /// Student model.
    /// </summary>
    [Serializable]
    public class StudentInfo : Entity
    {
        /// <summary>
        /// Property student's name.
        /// </summary>
        public string StudentName { get; set; }
    }
}
