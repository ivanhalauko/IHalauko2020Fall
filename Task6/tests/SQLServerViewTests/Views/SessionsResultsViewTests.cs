using NUnit.Framework;
using SQLServerView.Views;
using SQLServerViewTests.TestCaseSources;
using System.Collections.Generic;
using System.Linq;

namespace SQLServerViewTests.Views
{
    /// <summary>
    /// Test cases for sessions results view class.
    /// </summary>
    [TestFixture()]
    public class SessionsResultsViewTests : MockParentView
    {
        /// <summary>
        /// Test for sessions results view no ordered.
        /// </summary>
        /// <param name="sessionName">Session name parameter.</param>
        /// <param name="groupName">Group name parameter.</param>
        /// <returns>Returns string.</returns>
        [Test, TestCaseSource(typeof(TestCaseSourcesSessionsResultsViewTests), "GiveToString_WhenNoOrdered_ThenOutIsToString")]
        public string GiveToString_WhenNoOrdered_ThenOutIsToString(string sessionName, string groupName)
        {
            //Arrange
            SessionsResultsView sessionsResultsView = new SessionsResultsView(Mock.Object);
            //Act
            IEnumerable<SessionsResultsView> actual = sessionsResultsView.GetView(sessionName, groupName).ToList();
            var actualString = sessionsResultsView.ToString(actual);
            return actualString;
        }

        /// <summary>
        /// Test for sessions results view ordered by descending name and rating.
        /// </summary>
        /// <param name="sessionName">Session name parameter.</param>
        /// <param name="groupName">Group name parameter.</param>
        /// <returns>Returns string.</returns>
        [Test, TestCaseSource(typeof(TestCaseSourcesSessionsResultsViewTests), "GiveToString_WhenOrderByDescendingNameAndRating_ThenOutIsToStringOrderBy")]
        public string GiveToString_WhenOrderByDescendingFirstNameAndValue_ThenOutIsToStringOrderBy(string sessionName, string groupName)
        {
            //Arrange
            SessionsResultsView sessionsResultsView = new SessionsResultsView(Mock.Object);
            //Act
            var actual = sessionsResultsView.GetView(sessionName, groupName).ToList().OrderByDescending(f => f.Name).ThenByDescending(v => v.Rating);
            var actualString = sessionsResultsView.ToString(actual);
            return actualString;
        }
    }
}
