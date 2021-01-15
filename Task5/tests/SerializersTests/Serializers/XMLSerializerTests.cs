using AVLTreeLib.Model;
using NUnit.Framework;
using StudentInformationClass;

namespace Serializers.Serializers.Tests
{
    /// <summary>
    /// Class for testing XMLSerializer.
    /// </summary>
    [TestFixture()]
    public class XMLSerializerTests
    {
        [Test()]
        public void GivenXmlSerializeStudentsRepository_ThenOutXmlSerialize()
        {
            //Actual
            XMLSerializer xMLSerializer = new XMLSerializer();
            StudentInfo firstStudent = new StudentInfo() { Id = 0, StudentName = "Pasha" };
            StudentInfo secondStudent = new StudentInfo() { Id = 1, StudentName = "Eugen" };
            StudentInfo thirdStudent = new StudentInfo() { Id = 3, StudentName = "Grisha" };

            AVLTree<StudentInfo> expectedStudentAVLTree = new AVLTree<StudentInfo>();
            //Act
            expectedStudentAVLTree.Add(firstStudent);
            expectedStudentAVLTree.Add(secondStudent);
            expectedStudentAVLTree.Add(thirdStudent);
            xMLSerializer.Serialize(expectedStudentAVLTree, "SerializeData");

            var actualRepository = xMLSerializer.Deserialize<AVLTree<StudentInfo>>("SerializeData/AVLTree`1.xml");

            Assert.AreEqual(expectedStudentAVLTree, actualRepository);
        }
    }
}