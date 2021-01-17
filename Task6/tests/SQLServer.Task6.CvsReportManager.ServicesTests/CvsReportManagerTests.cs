using NUnit.Framework;
using SQLServer.Task6.CvsReportManager.Services.Utils;
using SQLServerViewTests.TestCaseSources;
using System.IO;

namespace SQLServer.Task6.CvsReportManager.Services.Tests
{
    /// <summary>
    /// Test cases to CvsReportManager.
    /// </summary>
    [TestFixture()]
    public class CvsReportManagerTests
    {
        /// <summary>
        /// Full name to directory path.
        /// </summary>
        private string directoryInfoFullName = new DirectoryInfo(@"xlsxData\\").FullName;

        /// <summary>
        /// Print SessionsResultsView.
        /// </summary>
        /// <param name="fileName">File name.</param>
        [TestCase("SessionOneGroupRF")]
        public void GivenPrint_WhenSessionsResultsView_ThenOutIsSessionOneGroupRF_Ordered(string fileName)
        {
            //Arrange
            CvsReportManager cvsReportManager = new CvsReportManager(new Excel(directoryInfoFullName, fileName), TestCaseSourcesSessionsResultsViewTests.SessionOneGroupRF_Ordered, ';');
            var expected = TestCaseSourcesSessionsResultsViewTests.SessionOneGroupRF_Ordered.Replace(" ", "");
            //Act
            cvsReportManager.Print();
            var actual = new Excel(directoryInfoFullName, fileName).Read(';').Replace(" ", "");
            //Arrange
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Print SessionsResultsView.
        /// </summary>
        /// <param name="fileName">File name.</param>
        [TestCase("SessionOneGroupTM")]
        public void GivenPrint_WhenSessionsResultsView_ThenOutIsSessionOneGroupTM_Ordered(string fileName)
        {
            //Arrange
            CvsReportManager cvsReportManager = new CvsReportManager(new Excel(directoryInfoFullName, fileName), TestCaseSourcesSessionsResultsViewTests.SessionOneGroupTM_Ordered, ';');
            var expected = TestCaseSourcesSessionsResultsViewTests.SessionOneGroupTM_Ordered.Replace(" ", "");
            //Act
            cvsReportManager.Print();
            var actual = new Excel(directoryInfoFullName, fileName).Read(';').Replace(" ", "");
            //Arrange
            Assert.AreEqual(expected, actual);
        }

    }
}