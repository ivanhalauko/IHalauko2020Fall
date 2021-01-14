using System;

namespace StudentInformationClass
{
    /// <summary>
    /// Class describe students tests information.
    /// </summary>
    [Serializable]
    public class TestsInfo : Entity
    {
        /// <summary>
        /// Property test's name.
        /// </summary>
        public string TestName { get; set; }
    }
}
