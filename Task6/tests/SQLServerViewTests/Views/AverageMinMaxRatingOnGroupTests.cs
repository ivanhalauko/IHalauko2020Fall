using NUnit.Framework;
using SQLServerViewTests;

namespace SQLServerView.Views.Tests
{
    [TestFixture()]
    public class AverageMinMaxRatingOnGroupTests : MockParentView
    {
        /// <summary>
        /// Test for max rating operation.
        /// </summary>
        /// <param name="sessionName">Session name.</param>
        /// <param name="groupName">Group name.</param>
        /// <param name="expected">Expected.</param>
        [TestCase("First", "RF", 97)]
        //[TestCase("First", "RF", 64)]
        //[TestCase("Second", "RF", 94)]
        //[TestCase("Second", "RF", 38)]
        public void GiveGetView_WhenMaxRating_ThenOutIsMaxRating(string sessionName, string groupName, int expected)
        {
            //Arrange
            AverageMinMaxRatingOnGroup maxOperationView = new AverageMinMaxRatingOnGroup(Mock.Object);
            //Act
            var actual = maxOperationView.GetView(sessionName, groupName).MaxRating;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test for min rating operation.
        /// </summary>
        /// <param name="sessionName">Session name.</param>
        /// <param name="groupName">Group name.</param>
        /// <param name="expected">Expected.</param>
        [TestCase("First", "RF", 27)]
        [TestCase("First", "RF", 16)]
        [TestCase("Second", "RF", 3)]
        [TestCase("Second", "RF", 5)]
        public void GiveGetView_WhenMinRating_ThenOutIsMinRating(string sessionName, string groupName, int expected)
        {
            //Arrange
            AverageMinMaxRatingOnGroup minOperationView = new AverageMinMaxRatingOnGroup(Mock.Object);
            //Act
            var actual = minOperationView.GetView(sessionName, groupName).MinRating;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test for average operation.
        /// </summary>
        /// <param name="sessionName">Session name.</param>
        /// <param name="groupName">Group name.</param>
        /// <param name="expected">Expected.</param>
        [TestCase("First", "RF", 58.399999999999999)]
        [TestCase("First", "RF", 37.0)]
        [TestCase("Second", "RF", 51.75)]
        [TestCase("Second", "RF", 19.5)]
        public void GiveGetView_WhenAverageRating_ThenOutIsAverageRating(string sessionName, string groupName, double expected)
        {
            //Arrange
            AverageMinMaxRatingOnGroup averageOperationsView = new AverageMinMaxRatingOnGroup(Mock.Object);
            //Act
            var actual = averageOperationsView.GetView(sessionName, groupName).AverageRating;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}