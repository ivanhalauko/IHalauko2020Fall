using Figures.Model.Lib.Enums;

namespace Figures.Model.Lib.Interfaces
{
	/// <summary>
	/// Interface IPaper.
	/// </summary>
	interface IPaper
	{
		/// <summary>
		/// Is recolored
		/// </summary>
		bool IsFigurePainted { get; }
		/// <summary>
		/// Property Colors
		/// </summary>
		ColorEnum Color { get; set; }
	}
}
