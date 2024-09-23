using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KukarskiySA.Sprint2.Task1.V16.Lib;

namespace Tyuiu.KukarskiySA.Sprint2.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetLogicOperations()
        {
            // Arrange
            DataService dataService = new DataService();
            int a = 145;
            int b = 716;
            int c = 144;
            int d = 137;

            // Act
            bool[] result = dataService.GetLogicOperations(a, b, c, d);

            // Assert
            bool[] expected = new bool[] { true, true, true, false, true, false };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
