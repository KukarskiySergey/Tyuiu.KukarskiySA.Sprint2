using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KukarskiySA.Sprint2.Task7.V5.Lib;

namespace Tyuiu.KukarskiySA.Sprint2.Task7.V5.Tests
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

        /// <summary>
        /// Проверяем точку, которая находится внутри заштрихованной области (x = 0, y = 1).
        /// </summary>
        [TestMethod]
        public void CheckDotInShadedArea_PointInside_ShouldReturnTrue()
        {
            // Arrange
            double x = 0;
            double y = 1;

            // Act
            bool result = _dataService.CheckDotInShadedArea(x, y);

            // Assert
            Assert.IsTrue(result, $"Точка ({x}, {y}) должна быть внутри заштрихованной области.");
        }

        /// <summary>
        /// Проверяем точку, которая находится вне заштрихованной области (x = -2, y = 2).
        /// </summary>
        [TestMethod]
        public void CheckDotInShadedArea_PointOutside_ShouldReturnFalse()
        {
            // Arrange
            double x = -2;
            double y = 2;

            // Act
            bool result = _dataService.CheckDotInShadedArea(x, y);

            // Assert
            Assert.IsFalse(result, $"Точка ({x}, {y}) не должна быть внутри заштрихованной области.");
        }

        /// <summary>
        /// Проверяем точку на границе заштрихованной области (x = 0.5, y = e^(-0.5)).
        /// </summary>
        [TestMethod]
        public void CheckDotInShadedArea_PointOnBoundary_ShouldReturnTrue()
        {
            // Arrange
            double x = 0.5;
            double y = Math.Exp(-0.5);

            // Act
            bool result = _dataService.CheckDotInShadedArea(x, y);

            // Assert
            Assert.IsTrue(result, $"Точка ({x}, {y}) должна быть на границе заштрихованной области.");
        }

        /// <summary>
        /// Проверяем точку, которая находится на нижней границе y = x^2 (x = 0.5, y = 0.25).
        /// </summary>
        [TestMethod]
        public void CheckDotInShadedArea_PointOnLowerBoundary_ShouldReturnTrue()
        {
            // Arrange
            double x = 0.5;
            double y = x * x; // y = 0.25

            // Act
            bool result = _dataService.CheckDotInShadedArea(x, y);

            // Assert
            Assert.IsTrue(result, $"Точка ({x}, {y}) должна быть на нижней границе заштрихованной области.");
        }

        /// <summary>
        /// Проверяем точку, которая находится за пределами диапазона по оси X (x = 1.5, y = 0).
        /// </summary>
        [TestMethod]
        public void CheckDotInShadedArea_PointOutsideXRange_ShouldReturnFalse()
        {
            // Arrange
            double x = 1.5;
            double y = 0;

            // Act
            bool result = _dataService.CheckDotInShadedArea(x, y);

            // Assert
            Assert.IsFalse(result, $"Точка ({x}, {y}) не должна быть в заштрихованной области, так как x выходит за пределы диапазона.");
        }
    }
}
