using DAO.DataAccesLayer.Singleton;
using SQLServerView.Abstract;
using SQLServerView.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerView.Views
{
    /// <summary>
    /// Class to view AverageScoreByExaminerView.
    /// </summary>
    public class AverageScoreByExaminerView : ParentView
    {
        /// <summary>
        /// Session name property.
        /// </summary>
        public int SessionName { get; private set; }

        /// <summary>
        /// First name property.
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Last name property.
        /// </summary>
        public string LastName { get; private set; }

        /// <summary>
        /// Middle name property.
        /// </summary>
        public string MiddleName { get; private set; }

        /// <summary>
        /// Average value property.
        /// </summary>
        public double AverageValue { get; private set; }

        /// <inheritdoc/>
        public AverageScoreByExaminerView() { }

        /// <inheritdoc/>
        public AverageScoreByExaminerView(IView view) : base(view) { }

        /// <inheritdoc/>
        public AverageScoreByExaminerView(SingletonAccessToDbo singletonAccessToDbo, IView view) : base(singletonAccessToDbo, view) { }

        /// <summary>
        /// Get view method.
        /// </summary>
        /// <param name="sessionName">Session name.</param>
        /// <param name="firstName">First name.</param>
        /// <param name="lastName"></param>
        /// <param name="middleName">Middle name.</param>
        /// <returns>Returns view.</returns>
        public AverageScoreByExaminerView GetView(int sessionName, string firstName, string lastName, string middleName)
        {
            var scoreResultsByExaminer =
                from itemSessionsResult in View.ExamStudResults.Where(x => string.IsNullOrEmpty(x.Value) != true).AsEnumerable()
                join itemStudents in View.Students.AsEnumerable()
                    on itemSessionsResult.StudentsId equals itemStudents.Id
                join itemExamShedules in View.ExamSchedules.AsEnumerable()
                    on itemSessionsResult.ExamSchedulesId equals itemExamShedules.Id
                join itemGroups in View.Groups.AsEnumerable()
                    on itemStudents.GroupsId equals itemGroups.Id
                join itemSessions in View.Sessions.Where(x => x.Name == sessionName).AsEnumerable()
                    on itemExamShedules.SessionsId equals itemSessions.Id
                join itemSubjects in View.Subjects.Where(x => x.IsAssessment == "True").AsEnumerable()
                    on itemExamShedules.SubjectsId equals itemSubjects.Id
                join itemExaminers in View.Examiners.Where(x => x.FirstName == firstName & x.LastName == lastName & x.MiddleName == middleName).AsEnumerable()
                    on itemSubjects.ExaminersId equals itemExaminers.Id
                select new
                {
                    itemSessions.Name,
                    itemExaminers.FirstName,
                    itemExaminers.LastName,
                    itemExaminers.MiddleName,
                    itemSessionsResult.Value
                };

            return new AverageScoreByExaminerView()
            {
                SessionName = sessionName,
                FirstName = firstName,
                LastName = lastName,
                MiddleName = middleName,
                AverageValue = scoreResultsByExaminer.Average(x => Convert.ToDouble(x.Value))
            };
        }

        /// <summary>
        /// Conver view to string.
        /// </summary>
        /// <param name="view">Average score by examiner view parameter.</param>
        /// <returns>Returns string.</returns>
        public string ToString(AverageScoreByExaminerView view)
        {
            string[] header = { "SessionName; FirstName; LastName; MiddleName; AverageValue" };
            string[] data = { $"{view.SessionName}; {view.FirstName}; {view.LastName}; {view.MiddleName}; {view.AverageValue.ToString()}" };

            return string.Join(Environment.NewLine, header.Concat(data));
        }
    }
}
