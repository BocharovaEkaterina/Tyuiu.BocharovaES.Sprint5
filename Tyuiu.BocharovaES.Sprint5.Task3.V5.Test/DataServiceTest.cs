using System.IO;
using Tyuiu.BocharovaES.Sprint5.Task3.V5.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.BocharovaES.Sprint5.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Пользователь\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
