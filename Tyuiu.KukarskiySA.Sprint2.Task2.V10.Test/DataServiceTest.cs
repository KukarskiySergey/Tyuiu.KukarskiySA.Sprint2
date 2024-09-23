using Tyuiu.KukarskiySA.Sprint2.Task2.V10.Lib;

namespace Tyuiu.KukarskiySA.Sprint2.Task2.V10.Test
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

        // Тест, когда точка находится внутри заштрихованной области
        [TestMethod]
        public void CheckDotInShadedArea_InsideShadedArea_ReturnsTrue()
        {
            // Arrange
            int x = 3;
            int y = 1;

            // Act
            bool result = dataService.CheckDotInShadedArea(x, y);

            // Assert
            Assert.IsTrue(result, $"Точка ({x}, {y}) должна находиться в заштрихованной области.");
        }

        // Тест, когда точка находится вне заштрихованной области
        [TestMethod]
        public void CheckDotInShadedArea_OutsideShadedArea_ReturnsFalse()
        {
            // Arrange
            int x = 1;
            int y = 1;

            // Act
            bool result = dataService.CheckDotInShadedArea(x, y);

            // Assert
            Assert.IsFalse(result, $"Точка ({x}, {y}) не должна находиться в заштрихованной области.");
        }

        // Тест на границе заштрихованной области (точка, которая находится на границе)
        [TestMethod]
        public void CheckDotInShadedArea_OnBorderOfShadedArea_ReturnsTrue()
        {
            // Arrange
            int x = 5;
            int y = 4;

            // Act
            bool result = dataService.CheckDotInShadedArea(x, y);

            // Assert
            Assert.IsTrue(result, $"Точка ({x}, {y}) должна находиться в заштрихованной области.");
        }

        // Тест для значений за пределами диапазона (например, x = 16, y = 0)
        [TestMethod]
        public void CheckDotInShadedArea_OutOfRange_ReturnsFalse()
        {
            // Arrange
            int x = 16;
            int y = 0;

            // Act
            bool result = dataService.CheckDotInShadedArea(x, y);

            // Assert
            Assert.IsFalse(result, $"Точка ({x}, {y}) находится вне диапазона допустимых значений.");
        }

        // Тест для точки в нижней заштрихованной области
        [TestMethod]
        public void CheckDotInShadedArea_LowerShadedArea_ReturnsTrue()
        {
            // Arrange
            int x = 9;
            int y = 13;

            // Act
            bool result = dataService.CheckDotInShadedArea(x, y);

            // Assert
            Assert.IsTrue(result, $"Точка ({x}, {y}) должна находиться в заштрихованной области.");
        }
    }
}