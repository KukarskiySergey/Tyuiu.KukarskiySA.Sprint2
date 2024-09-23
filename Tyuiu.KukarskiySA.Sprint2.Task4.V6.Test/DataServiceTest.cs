using Tyuiu.KukarskiySA.Sprint2.Task4.V6.Lib;

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
            double expected = Math.Pow(x * ((y + 1) / (x + 2)), x);
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

        [TestMethod]
        public void Calculate_WhenXIsZero_ShouldHandleProperly()
        {
            // Arrange
            double x = 0;
            double y1 = 5;
            double y2 = 15;

            // Act
            double resultWhenTrue = _dataService.Calculate(x, y1);
            double resultWhenFalse = _dataService.Calculate(x, y2);

            // Assert
            Assert.AreEqual(1, resultWhenTrue, "ќжидает 1 когда x = 0 и услови€ true.");
            Assert.IsTrue(double.IsInfinity(resultWhenFalse), "ќжидает бесконечность, когда x = 0 и услови€ false.");
        }
    }
}