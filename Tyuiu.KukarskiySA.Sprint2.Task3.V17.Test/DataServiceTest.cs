using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KukarskiySA.Sprint2.Task3.V10.Lib;

namespace Sprint2Task3Tests
{
    [TestClass]
    public class DataServiceTests
    {
        private DataService dataService;

        [TestInitialize]
        public void Setup()
        {
            dataService = new DataService();
        }

        // Тест для случая, когда x = 0
        [TestMethod]
        public void CalculateFunction_XEquals0_ReturnsCorrectValue()
        {
            // Arrange
            double x = 0;

            // Act
            double result = dataService.Calculate(x);

            // Assert
            Assert.AreEqual(-3.5, result, 0.001, "Значение функции для x = 0 неверно.");
        }

        // Тест для случая, когда x <= -21
        [TestMethod]
        public void CalculateFunction_XLessThanOrEqualToMinus21_ReturnsCorrectValue()
        {
            // Arrange
            double x = -22;

            // Act
            double result = dataService.Calculate(x);

            // Assert
            Assert.AreEqual(-241.955, result, 0.001, "Значение функции для x <= -21 неверно.");
        }
    }
}
