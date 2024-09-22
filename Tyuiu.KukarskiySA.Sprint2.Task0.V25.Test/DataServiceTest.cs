using Tyuiu.KukarskiySA.Sprint2.Task0.V25.Lib;

namespace Tyuiu.KukarskiySA.Sprint2.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTests
    {
        private DataService _dataService;

        [TestInitialize]
        public void Setup()
        {
            _dataService = new DataService();
        }

        [TestMethod]
        public void GetCompareOperations_ShouldReturnExpectedResults_WhenXIs205AndYIs159()
        {
            // Arrange
            int x = 205;
            int y = 159;
            bool[] expectedResults = new bool[] { true, true, true, false, false, false };

            // Act
            bool[] actualResults = _dataService.GetCompareOperations(x, y);

            // Assert
            CollectionAssert.AreEqual(expectedResults, actualResults, "Результаты сравнения не соответствуют ожидаемым.");
        }

        [TestMethod]
        public void GetCompareOperations_ShouldReturnExpectedResults_WhenXIs200AndYIs205()
        {
            // Arrange
            int x = 200;
            int y = 205;
            bool[] expectedResults = new bool[] { false, true, false, true, true, true }; // Исправленные ожидаемые результаты

            // Act
            bool[] actualResults = _dataService.GetCompareOperations(x, y);

            // Assert
            CollectionAssert.AreEqual(expectedResults, actualResults, "Результаты сравнения не соответствуют ожидаемым.");
        }

        [TestMethod]
        public void GetCompareOperations_ShouldReturnExpectedResults_WhenXAndYAreEqual()
        {
            // Arrange
            int x = 100;
            int y = 100;
            bool[] expectedResults = new bool[] { false, false, false, false, true, true };

            // Act
            bool[] actualResults = _dataService.GetCompareOperations(x, y);

            // Assert
            CollectionAssert.AreEqual(expectedResults, actualResults, "Результаты сравнения не соответствуют ожидаемым.");
        }
    }
}