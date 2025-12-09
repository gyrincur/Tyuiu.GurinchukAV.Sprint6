using System.IO;
using Tyuiu.GurinchukAV.Sprint6.Task5.V26.Lib;
namespace Tyuiu.GurinchukAV.Sprint6.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void LoadFromDataFile_ValidFile_ReturnsCorrectData()
        {
            // Arrange
            var service = new DataService();
            string filePath = Path.GetTempFileName();
            File.WriteAllLines(filePath, new[] { "5.000", "10", "15.555", "-20.0", "12.3" });

            // Act
            double[] result = service.LoadFromDataFile(filePath);

            // Assert
            CollectionAssert.AreEqual(new[] { 5.0, 10.0, -20.0 }, result);

            // Cleanup
            File.Delete(filePath);
        }
    }
}