using DAO.DataAccesLayer.Singleton;
using SQLServerView.Abstract;
using SQLServerView.Interface;
using System;
using System.Linq;

namespace SQLServerView.Views
{
    /// <summary>
    /// Class session result view.
    /// </summary>
    public class AverageMinMaxRatingOnGroup : ParentView
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
        /// MaxValue column.
        /// </summary>
        public int MaxRating { get; set; }

        /// <summary>
        /// MinValue column.
        /// </summary>
        public int MinRating { get; set; }

        /// <summary>
        /// AverageRating column.
        /// </summary>
        public double AverageRating { get; set; }
        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public AverageMinMaxRatingOnGroup() { }
        /// <summary>
        /// Constructor with initialize parameters.
        /// </summary>
        /// <param name="view">View property.</param>
        public AverageMinMaxRatingOnGroup(IView view) : base(view) { }
        /// <summary>
        /// Constructor with initialize parameters.
        /// </summary>
        /// <param name="singletonAccessToDbo">SingletonAccessToDbo parameter.</param>
        /// <param name="view">View property.</param>
        public AverageMinMaxRatingOnGroup(SingletonAccessToDbo singletonAccessToDbo, IView view) : base(singletonAccessToDbo, view) { }

		/// <summary>
		/// Method for get view.
		/// </summary>
		/// <param name="sessionName">Session name parameter.</param>
		/// <param name="groupName">Group name parameter.</param>
		/// <returns>Returns new view.</returns>
		public AverageMinMaxRatingOnGroup GetView(string sessionName, string groupName)
		{
			var aggregateValue =
				from itemSessionsResult in View.ExamStudResults
				join itemStudents in View.Students
					on itemSessionsResult.IDStudent equals itemStudents.Id
				join itemExamShedules in View.ExamsForGroups
					on itemSessionsResult.IDExamForGroupe equals itemExamShedules.Id
				join itemGroups in View.Groups
					on itemStudents.IDGroupe equals itemGroups.Id
				join itemSessions in View.ExamTerms
					on itemExamShedules.IDExamTerm equals itemSessions.Id
				join itemSubjects in View.Subjects
					on itemExamShedules.IDSubjects equals itemSubjects.Id
				where itemSessions.ExamTermName == sessionName & itemGroups.GroupeName == groupName
				select new
				{
					SessionName = itemSessions.ExamTermName,
					GroupName = itemGroups.GroupeName,
					Value = itemSessionsResult.Rating
				};

			return new AverageMinMaxRatingOnGroup()
			{
				NameOfSession = sessionName,
				NameOfGroup = groupName,
				AverageRating = aggregateValue.Average(x => Convert.ToDouble(x.Value)),
				MaxRating = aggregateValue.Max(x => Convert.ToInt32(x.Value)),
				MinRating = aggregateValue.Min(x => Convert.ToInt32(x.Value))
			};
		}

		/// <summary>
		/// Conver view to string.
		/// </summary>
		/// <param name="view">Aggregate operations view parameter.</param>
		/// <returns>Returns string.</returns>
		public string ToString(AverageMinMaxRatingOnGroup view)
        {
            string[] header = { "NameOfSession; NameOfGroup; AverageRating; MaxRating; MinRating" };
            string[] data = { $"{view.NameOfSession}; {view.NameOfGroup}; {view.AverageRating.ToString()}; " +
                    $"{view.MaxRating.ToString()}; {view.MinRating.ToString()}" };

            return string.Join(System.Environment.NewLine, header.Concat(data));
        }

    }
}
