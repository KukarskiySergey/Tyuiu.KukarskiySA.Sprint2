using Tyuiu.KukarskiySA.Sprint2.Task4.V6.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.KukarskiySA.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private DataService _dataService;

        [TestInitialize]
        public void Setup()
        {
            _dataService = new DataService();
        }

        [TestMethod]
        public void Calculate_WhenConditionIsTrue_ShouldUseFirstExpression()
        {
            // Arrange
            double x = 10;
            double y = 5;

            // Act
            double result = _dataService.Calculate(x, y);

            // Assert
            double expected = x * Math.Pow((y + 1) / (x + 2), x); // Исправлено
            Assert.AreEqual(expected, result, 1e-6);
        }

        [TestMethod]
        public void Calculate_WhenConditionIsFalse_ShouldUseSecondExpression()
        {
            // Arrange
            double x = 1;
            double y = 15;

            // Act
            double result = _dataService.Calculate(x, y);

            // Assert
            double expected = Math.Pow(y, 2) + 2 * x + (6 / x);
            Assert.AreEqual(expected, result, 1e-6);
        }

        // Добавим тест для проверки на вашем примере (x = 9, y = 4)
        [TestMethod]
        public void Calculate_WhenXIsNineAndYIsFour_ShouldReturnExpectedValue()
        {
            // Arrange
            double x = 9;
            double y = 4;

            // Act
            double result = _dataService.Calculate(x, y);

            // Assert
            double expected = x * Math.Pow((y + 1) / (x + 2), x); // Ожидаемое значение
            Assert.AreEqual(expected, result, 1e-6);
        }
    }
}