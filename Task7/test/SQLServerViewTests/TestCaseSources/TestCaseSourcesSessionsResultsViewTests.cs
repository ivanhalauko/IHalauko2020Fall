using NUnit.Framework;
using System.Collections;

namespace SQLServerViewTests.TestCaseSources
{
    /// <summary>
    /// Source for test cases.
    /// </summary>
    public class TestCaseSourcesSessionsResultsViewTests
    {
        /// <summary>
        /// String implementation for session one group RF and no ordered.
        /// </summary>
        public static readonly string SessionOneGroupRF_NoOrdered =
            "SessionName; GroupName; Name; Surname; Patronymic; NameOfExam; Rating\r\n" +
            "1; RF; Name2; Surname2; Patronymic2; Philosophy; 5\r\n" +
            "1; RF; Name2; Surname2; Patronymic2; Math; 3\r\n" +
            "1; RF; Name2; Surname2; Patronymic2; Chemistry; 8\r\n" +
            "1; RF; Name3; Surname3; Patronymic3; Philosophy; 6\r\n" +
            "1; RF; Name3; Surname3; Patronymic3; Math; 7\r\n" +
            "1; RF; Name3; Surname3; Patronymic3; Chemistry; 7\r\n" +
            "1; RF; Name4; Surname4; Patronymic4; Philosophy; 5\r\n" +
            "1; RF; Name4; Surname4; Patronymic4; Math; 8\r\n" +
            "1; RF; Name4; Surname4; Patronymic4; Chemistry; 9\r\n" +
            "1; RF; Name5; Surname5; Patronymic5; Philosophy; 5\r\n" +
            "1; RF; Name5; Surname5; Patronymic5; Math; 6\r\n" +
            "1; RF; Name5; Surname5; Patronymic5; Chemistry; 4\r\n" +
            "1; RF; Name8; Surname8; Patronymic8; Philosophy; 8\r\n" +
            "1; RF; Name8; Surname8; Patronymic8; Math; 9\r\n" +
            "1; RF; Name8; Surname8; Patronymic8; Chemistry; 4";

        /// <summary>
        /// String implementation for session one group TM and no ordered.
        /// </summary>
        public static readonly string SessionOneGroupTM_NoOrdered =
            "SessionName; GroupName; Name; Surname; Patronymic; NameOfExam; Rating\r\n" +
            "1; TM; Name2; Surname2; Patronymic2; Philosophy; 5\r\n" +
            "1; TM; Name2; Surname2; Patronymic2; Math; 3\r\n" +
            "1; TM; Name2; Surname2; Patronymic2; Chemistry; 8\r\n" +
            "1; TM; Name3; Surname3; Patronymic3; Philosophy; 6\r\n" +
            "1; TM; Name3; Surname3; Patronymic3; Math; 7\r\n" +
            "1; TM; Name3; Surname3; Patronymic3; Chemistry; 7\r\n" +
            "1; TM; Name4; Surname4; Patronymic4; Philosophy; 5\r\n" +
            "1; TM; Name4; Surname4; Patronymic4; Math; 8\r\n" +
            "1; TM; Name4; Surname4; Patronymic4; Chemistry; 9\r\n" +
            "1; TM; Name5; Surname5; Patronymic5; Philosophy; 5\r\n" +
            "1; TM; Name5; Surname5; Patronymic5; Math; 6\r\n" +
            "1; TM; Name5; Surname5; Patronymic5; Chemistry; 4\r\n" +
            "1; TM; Name8; Surname8; Patronymic8; Philosophy; 8\r\n" +
            "1; TM; Name8; Surname8; Patronymic8; Math; 9\r\n" +
            "1; TM; Name8; Surname8; Patronymic8; Chemistry; 4";

        /// <summary>
        /// String implementation for session one group RF and  ordered.
        /// </summary>
        public static readonly string SessionOneGroupRF_Ordered =
            "SessionName; GroupName; Name; Surname; Patronymic; NameOfExam; Rating\r\n" +
            "1; RF; Name2; Surname2; Patronymic2; Philosophy; 5\r\n" +
            "1; RF; Name2; Surname2; Patronymic2; Math; 3\r\n" +
            "1; RF; Name2; Surname2; Patronymic2; Chemistry; 8\r\n" +
            "1; RF; Name3; Surname3; Patronymic3; Philosophy; 6\r\n" +
            "1; RF; Name3; Surname3; Patronymic3; Math; 7\r\n" +
            "1; RF; Name3; Surname3; Patronymic3; Chemistry; 7\r\n" +
            "1; RF; Name4; Surname4; Patronymic4; Philosophy; 5\r\n" +
            "1; RF; Name4; Surname4; Patronymic4; Math; 8\r\n" +
            "1; RF; Name4; Surname4; Patronymic4; Chemistry; 9\r\n" +
            "1; RF; Name5; Surname5; Patronymic5; Philosophy; 5\r\n" +
            "1; RF; Name5; Surname5; Patronymic5; Math; 6\r\n" +
            "1; RF; Name5; Surname5; Patronymic5; Chemistry; 4\r\n" +
            "1; RF; Name8; Surname8; Patronymic8; Philosophy; 8\r\n" +
            "1; RF; Name8; Surname8; Patronymic8; Math; 9\r\n" +
            "1; RF; Name8; Surname8; Patronymic8; Chemistry; 4";

        /// <summary>
        /// String implementation for session one group TM and  ordered.
        /// </summary>
        public static readonly string SessionOneGroupTM_Ordered =
            "SessionName; GroupName; Name; Surname; Patronymic; NameOfExam; Rating\r\n" +
            "1; TM; Name2; Surname2; Patronymic2; Philosophy; 5\r\n" +
            "1; TM; Name2; Surname2; Patronymic2; Math; 3\r\n" +
            "1; TM; Name2; Surname2; Patronymic2; Chemistry; 8\r\n" +
            "1; TM; Name3; Surname3; Patronymic3; Philosophy; 6\r\n" +
            "1; TM; Name3; Surname3; Patronymic3; Math; 7\r\n" +
            "1; TM; Name3; Surname3; Patronymic3; Chemistry; 7\r\n" +
            "1; TM; Name4; Surname4; Patronymic4; Philosophy; 5\r\n" +
            "1; TM; Name4; Surname4; Patronymic4; Math; 8\r\n" +
            "1; TM; Name4; Surname4; Patronymic4; Chemistry; 9\r\n" +
            "1; TM; Name5; Surname5; Patronymic5; Philosophy; 5\r\n" +
            "1; TM; Name5; Surname5; Patronymic5; Math; 6\r\n" +
            "1; TM; Name5; Surname5; Patronymic5; Chemistry; 4\r\n" +
            "1; TM; Name8; Surname8; Patronymic8; Philosophy; 8\r\n" +
            "1; TM; Name8; Surname8; Patronymic8; Math; 9\r\n" +
            "1; TM; Name8; Surname8; Patronymic8; Chemistry; 4";

        /// <summary>
        /// Parameters for tests TestCaseSourcesSessionsResultsViewTests
        /// </summary>
        public static IEnumerable GiveToString_WhenNoOrdered_ThenOutIsToString
        {
            get
            {
                yield return new TestCaseData("1", "RF").Returns(SessionOneGroupRF_NoOrdered);
                yield return new TestCaseData("1", "TM").Returns(SessionOneGroupTM_NoOrdered);
            }
        }
        /// <summary>
        /// Parameters for tests TestCaseSourcesSessionsResultsViewTests and ordered.
        /// </summary>
        public static IEnumerable GiveToString_WhenOrderByDescendingFirstNameAndValue_ThenOutIsToStringOrderBy
        {
            get
            {
                yield return new TestCaseData("1", "RF").Returns(SessionOneGroupRF_Ordered);
                yield return new TestCaseData("1", "TM").Returns(SessionOneGroupTM_Ordered);
            }
        }
    }
}
