using DAO.DataAccesLayer.Singleton;
using SQLServerView.Abstract;
using SQLServerView.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLServerView.Views
{
    /// <summary>
    /// Students to be expelled view.
    /// </summary>
    public class ExpelledStudentsView : ParentView
    {
        /// <summary>
        /// Name of session property.
        /// </summary>
        public string NameOfSession { get; set; }

        /// <summary>
        /// Name of group property.
        /// </summary>
        public string NameOfGroup { get; set; }

        /// <summary>
        /// Student's name property.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Student's surname property.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Student's patronymic property.
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Student's ID property.
        /// </summary>
        public int IDStudent { get; set; }

        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public ExpelledStudentsView()
        {
        }

        /// <summary>
        /// Constructor with initialize parameters.
        /// </summary>
        /// <param name="view">View property.</param>
        public ExpelledStudentsView(IView view) : base(view)
        {
        }

        /// <summary>
        /// Constructor with initialize parameters.
        /// </summary>
        /// <param name="singletonAccessToDbo">SingletonAccessToDbo parameter.</param>
        /// <param name="view">View property.</param>
        public ExpelledStudentsView(SingletonAccessToDbo singletonAccessToDbo, IView view) : base(singletonAccessToDbo, view)
        {
        }
        ///// <summary>
        ///// Method for get view.
        ///// </summary>
        ///// <param name="sessionName">Session name parameter.</param>
        ///// <param name="minPassingGrade">Session minimum passing grade parameter.</param>
        ///// <returns>Returns new view.</returns>
        //public IEnumerable<IGrouping<string, ExpelledStudentsView>> GetView(string sessionName, int minPassingGrade)
        //{
        //    IEnumerable<ExpelledStudentsView> studentsToBeExpelled =
        //        (from itemSessionsResult in View.ExamStudResults
        //         join itemStudents in View.Students
        //             on itemSessionsResult.IDStudent equals itemStudents.Id
        //         join itemExamShedules in View.ExamsForGroups
        //             on itemSessionsResult.IDExamForGroupe equals itemExamShedules.Id
        //         join itemGroups in View.Groups
        //             on itemStudents.IDGroupe equals itemGroups.Id
        //         join itemSessions in View.ExamTerms
        //             on itemExamShedules.IDExamTerm equals itemSessions.Id
        //         join itemSubjects in View.Exams
        //             on itemExamShedules.IDExam equals itemSubjects.Id
        //         where itemSessions.ExamTermName == sessionName
        //             & itemSessionsResult.Rating != 0
        //         where Convert.ToInt32(itemSessionsResult.Rating) < minPassingGrade
        //         select new ExpelledStudentsView
        //         {
        //             IDStudent = itemStudents.Id,
        //             NameOfSession = itemSessions.ExamTermName,
        //             NameOfGroup = itemGroups.GroupeName,
        //             Name = itemStudents.Name,
        //             Surname = itemStudents.Surname,
        //             Patronymic = itemStudents.Patronymic
        //         }).GroupBy(x => x.IDStudent).Select(y => y.First());

        //    var studentsToBeExpelledGroupedByGroup =
        //        from itemStudentsToBeExpelled in studentsToBeExpelled
        //        group itemStudentsToBeExpelled by itemStudentsToBeExpelled.NameOfGroup;

        //    return studentsToBeExpelledGroupedByGroup;
        //}

        /// <summary>
        /// Conver view to string.
        /// </summary>
        /// <param name="studentsToBeExpelledGrouped">Students to be expelled grouped parameter.</param>
        /// <returns>Returns string.</returns>
        public string ToString(IEnumerable<IEnumerable<ExpelledStudentsView>> studentsToBeExpelledGrouped)
        {
            string[] header = { "IDStudent; NameOfSession; NameOfGroup; Name; Surname; Patronymic" };
            var dataArray = studentsToBeExpelledGrouped.ToArray();
            var appendedLine = new StringBuilder().AppendLine(string.Concat(header));

            for (int i = 0; i < dataArray.Length; i++)
            {
                foreach (var item in dataArray[i])
                    appendedLine.AppendLine($"{item.IDStudent}; {item.NameOfSession}; {item.NameOfGroup}; {item.Name}; {item.Surname}; {item.Patronymic}");
            }
            return appendedLine.ToString();
        }
    }
}
