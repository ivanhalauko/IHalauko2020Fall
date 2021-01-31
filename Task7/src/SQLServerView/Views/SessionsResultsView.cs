using DAO.DataAccesLayer.Singleton;
using SQLServerView.Abstract;
using SQLServerView.Interface;
using System.Collections.Generic;
using System.Linq;

namespace SQLServerView.Views
{
    /// <summary>
    /// Class session result view.
    /// </summary>
    public class SessionsResultsView : ParentView
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
        /// Name of exam property.
        /// </summary>
        public string NameOfExam { get; set; }

        /// <summary>
        /// Student's rating.
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public SessionsResultsView()
        {
        }

        /// <summary>
        /// Constructor with initialize parameters.
        /// </summary>
        /// <param name="view">View property.</param>
        public SessionsResultsView(IView view) : base(view)
        {
        }

        /// <summary>
        /// Constructor with initialize parameters.
        /// </summary>
        /// <param name="singletonAccessToDbo">SingletonAccessToDbo parameter.</param>
        /// <param name="view">View property.</param>
        public SessionsResultsView(SingletonAccessToDbo singletonAccessToDbo, IView view) : base(singletonAccessToDbo, view)
        {
        }

		/// <summary>
		/// Method for get view.
		/// </summary>
		/// <param name="nameOfSession">Name of session parameter.</param>
		/// <param name="nameOfGroup">Name of group parameter.</param>
		/// <returns>Return view.</returns>
		public IEnumerable<SessionsResultsView> GetView(string nameOfSession, string nameOfGroup)
		{
			IEnumerable<SessionsResultsView> sessionResultsView =
				from itemSessionResult in View.ExamStudResults
				join itemStudents in View.Students
					on itemSessionResult.IDStudent equals itemStudents.Id

				join itemExamForGroups in View.ExamsForGroups
					on itemSessionResult.IDExamForGroupe equals itemExamForGroups.Id

				join itemGroups in View.Groups
					on itemStudents.IDGroupe equals itemGroups.Id

				join itemSession in View.ExamTerms
				on itemExamForGroups.IDExamTerm equals itemSession.Id

				join itemExam in View.Subjects
					on itemExamForGroups.IDSubjects equals itemExam.Id

				where itemSession.ExamTermName == nameOfSession & itemGroups.GroupeName == nameOfGroup //& int.I //IsNullOrEmpty(itemSessionResult.Rating)!=true

				select new SessionsResultsView
				{
					NameOfSession = itemSession.ExamTermName,
					NameOfGroup = itemGroups.GroupeName,
					Surname = itemStudents.Surname,
					Name = itemStudents.Name,
					Patronymic = itemStudents.Patronymic,
					NameOfExam = itemExam.SubjectsName,
					Rating = itemSessionResult.Rating
				};
			return sessionResultsView;
		}

		/// <summary>
		/// Method convert view to string.
		/// </summary>
		/// <param name="sessionResultView"></param>
		/// <returns></returns>
		public string ToString(IEnumerable<SessionsResultsView> sessionResultView)
        {
            string[] header = { "SessionName; GroupName; Name; Surname; Patronymic; NameOfExam; Rating" };
            string[] data = sessionResultView.Select(p => string.Format("{0}; {1}; {2}; {3}; {4}; {5}; {6}", p.NameOfSession, p.NameOfGroup,
                p.Name, p.Surname, p.Patronymic, p.NameOfExam, p.Rating)).ToArray();

            return string.Join(System.Environment.NewLine, header.Concat(data));
        }
    }
}
