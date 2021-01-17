using NUnit.Framework;
using SQLServerView.Views;
using SQLServerViewTests.TestCaseSources;
using System.Linq;

namespace SQLServerViewTests.Views
{
    [TestFixture()]
    public class ExpelledStudentsViewTests
    {
        /// <summary>
        /// Test cases for students to be expelled view.
        /// </summary>
        [TestFixture()]
        public class StudentsToBeExpelledViewTests : MockParentView
        {
            /// <summary>
            /// Test for students to be expelled view no ordered.
            /// </summary>
            /// <param name="sessionName">Session name parameter.</param>
            /// <param name="minPassingGrade">Minimum passing grade parameter.</param>
            /// <returns>Returns string.</returns>
            [Test, TestCaseSource(typeof(TestCaseSourcesExpelledStudentsView), "GiveToString_WhenNoOrdered_ThenOutIsToString")]
            public string GiveToString_WhenNoOrdered_ThenOutIsToString(string sessionName, int minPassingGrade)
            {
                //Arrange
                ExpelledStudentsView expelledStudentsView = new ExpelledStudentsView(Mock.Object);
                //Act
                var actual = expelledStudentsView.GetView(sessionName, minPassingGrade).ToList();
                var actualString = expelledStudentsView.ToString(actual);
                return actualString;
            }

            /// <summary>
            /// Test for students to be expelled view no ordered.
            /// </summary>
            /// <param name="sessionName">Session name parameter.</param>
            /// <param name="minPassingGrade">Minimum passing grade parameter.</param>
            /// <returns>Returns string.</returns>
            [Test, TestCaseSource(typeof(TestCaseSourcesExpelledStudentsView), "GiveToString_WhenOrderByGroupNameAndStudentId_ThenOutIsToStringOrderByGroupNameAndStudentId")]
            public string GiveToString_WhenOrderByGroupNameAndStudentId_ThenOutIsToStringOrderByGroupNameAndStudentId(string sessionName, int minPassingGrade)
            {
                //Arrange
                ExpelledStudentsView expelledStudentsView = new ExpelledStudentsView(Mock.Object);
                //Act
                var actual = expelledStudentsView.GetView(sessionName, minPassingGrade).ToList().OrderBy(x => x.Key).Select(k => k.OrderBy(g => g.NameOfGroup).ThenBy(i => i.IDStudent));
                var actualString = expelledStudentsView.ToString(actual);
                return actualString;
            }
        }
    }
}
