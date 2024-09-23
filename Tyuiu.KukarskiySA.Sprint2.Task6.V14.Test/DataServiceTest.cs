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
            int k = 1;  // 1-� ���� ����
            int d = 1;  // 1 ������ � �����������

            // Act
            string result = _dataService.FindDayName(k, d);

            // Assert
            Assert.AreEqual("�����������", result);
        }

        [TestMethod]
        public void FindDayName_ReturnsWednesday_WhenKIs3AndDIs1()
        {
            // Arrange
            int k = 3;  // 3-� ���� ����
            int d = 1;  // 1 ������ � �����������

            // Act
            string result = _dataService.FindDayName(k, d);

            // Assert
            Assert.AreEqual("�����", result);
        }

        [TestMethod]
        public void FindDayName_ReturnsSunday_WhenKIs7AndDIs1()
        {
            // Arrange
            int k = 7;  // 7-� ���� ����
            int d = 1;  // 1 ������ � �����������

            // Act
            string result = _dataService.FindDayName(k, d);

            // Assert
            Assert.AreEqual("�����������", result);
        }

        [TestMethod]
        public void FindDayName_ReturnsTuesday_WhenKIs1AndDIs2()
        {
            // Arrange
            int k = 1;  // 1-� ���� ����
            int d = 2;  // 1 ������ � �������

            // Act
            string result = _dataService.FindDayName(k, d);

            // Assert
            Assert.AreEqual("�������", result);
        }
    }
}