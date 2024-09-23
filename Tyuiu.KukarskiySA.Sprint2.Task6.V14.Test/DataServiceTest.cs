using Tyuiu.KukarskiySA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.KukarskiySA.Sprint2.Task6.V14.Test
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
        public void FindDayName_ReturnsMonday_WhenKIs1AndDIs1()
        {
            // Arrange
            int k = 1;  // 1-й день года
            int d = 1;  // 1 €нвар€ Ч понедельник

            // Act
            string result = _dataService.FindDayName(k, d);

            // Assert
            Assert.AreEqual("ѕонедельник", result);
        }

        [TestMethod]
        public void FindDayName_ReturnsWednesday_WhenKIs3AndDIs1()
        {
            // Arrange
            int k = 3;  // 3-й день года
            int d = 1;  // 1 €нвар€ Ч понедельник

            // Act
            string result = _dataService.FindDayName(k, d);

            // Assert
            Assert.AreEqual("—реда", result);
        }

        [TestMethod]
        public void FindDayName_ReturnsSunday_WhenKIs7AndDIs1()
        {
            // Arrange
            int k = 7;  // 7-й день года
            int d = 1;  // 1 €нвар€ Ч понедельник

            // Act
            string result = _dataService.FindDayName(k, d);

            // Assert
            Assert.AreEqual("¬оскресенье", result);
        }

        [TestMethod]
        public void FindDayName_ReturnsTuesday_WhenKIs1AndDIs2()
        {
            // Arrange
            int k = 1;  // 1-й день года
            int d = 2;  // 1 €нвар€ Ч вторник

            // Act
            string result = _dataService.FindDayName(k, d);

            // Assert
            Assert.AreEqual("¬торник", result);
        }
    }
}