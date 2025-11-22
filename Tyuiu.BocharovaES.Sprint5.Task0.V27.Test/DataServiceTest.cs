using System.IO;
using Tyuiu.BocharovaES.Sprint5.Task0.V27.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.BocharovaES.Sprint5.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Пользователь\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileInfo= new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
