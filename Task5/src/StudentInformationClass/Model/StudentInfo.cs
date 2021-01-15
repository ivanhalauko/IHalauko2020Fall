using System;

namespace StudentInformationClass
{
    /// <summary>
    /// Student model.
    /// </summary>
    [Serializable]
    public class StudentInfo : Entity
    {
		public StudentInfo(): base() { }

		/// <summary>
		/// Property student's name.
		/// </summary>
		public string StudentName { get; set; }


    }
}
