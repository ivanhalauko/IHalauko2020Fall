namespace Shapes.Model.Lib.Interfaces
{
	/// <summary>
	/// Base shape contract. 
	/// </summary>
	interface IBaseShape
	{
		/// <summary>
		/// Property figure's area 
		/// </summary>
		double Area { get; }
		/// <summary>
		/// Property figure's perimetr.
		/// </summary>
		double Perimeter { get; }
		/// <summary>
		/// Base method ToString for get name of class.
		/// </summary>
		/// <returns></returns>
		string ToString();
	}
}
