using NUnit.Framework;
using System.Collections;

namespace SQLServerViewTests.TestCaseSources
{
    /// <summary>
    /// Test case sources average min/max and rating on group view.
    /// </summary>
    public class TestCaseSourcesAverageMinMaxRatingOnGroupTests
    {
        /// <summary>
        /// String implementation for first session and group RF.
        /// </summary>
        public static readonly string FirstSessionGroupRF =
            "SessionName; GroupName; AverageValue; MaxValue; MinValue\r\n" +
            "First; RF; 58,4; 97; 27";
        /// <summary>
        /// String implementation for first session and group TM.
        /// </summary>
        public static readonly string FirstSessionGroupTM =
            "SessionName; GroupName; AverageValue; MaxValue; MinValue\r\n" +
            "First; TM; 37; 64; 16";

        /// <summary>
        /// String implementation for session two and group PM-1.
        /// </summary>
        public static readonly string SecondSessionGroupRF =
            "SessionName; GroupName; AverageValue; MaxValue; MinValue\r\n" +
            "Second; RF; 51,75; 94; 3";

        /// <summary>
        /// String implementation for session two and group PM-2.
        /// </summary>
        public static readonly string SecondSessionGroupTM =
            "SessionName; GroupName; AverageValue; MaxValue; MinValue\r\n" +
            "Second; TM; 19,5; 38; 5";

        /// <summary>
        /// Parameters for tests AggregateOperationsView.
        /// </summary>
        public static IEnumerable GiveToString_ThenOutIsToString
        {
            get
            {
                yield return new TestCaseData("First", "RF").Returns(FirstSessionGroupRF);
                yield return new TestCaseData("First", "TM").Returns(FirstSessionGroupTM);
                yield return new TestCaseData("Second", "RF").Returns(SecondSessionGroupRF);
                yield return new TestCaseData("Second", "TM").Returns(SecondSessionGroupTM);
            }
        }
    }
}
