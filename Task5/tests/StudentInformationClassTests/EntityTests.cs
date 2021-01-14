using NUnit.Framework;
using StudentInformationClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationClass.Tests
{
	[TestFixture()]
	public class EntityTests
	{
		/// <summary>
		/// Given compare two nodes value when value is positive int then out is negative value.
		/// </summary>
		/// <param name="firstValue">First value parameter.</param>
		/// <param name="secondValue">Second value parameter.</param>
		/// <param name="expectedValue">Expected value parameter.</param>
		[TestCase(6, 7, -1)]
		[TestCase(1, 2, -1)]
		public void GivenCompareTwoStudents_WhenValueString_ThenOutIsTrue(
			int firstValue, int secondValue, int expectedValue)
		{
			//Arrange
			Entity oneNode = new Entity();

			//Act
			var actualResult = oneNode.CompareTo(secondValue);
			//Assert
			Assert.AreEqual(expectedValue, actualResult);
		}
	}
}