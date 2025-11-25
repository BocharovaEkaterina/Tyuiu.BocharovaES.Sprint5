using System.IO;
using Tyuiu.BocharovaES.Sprint5.Task7.V9.Lib;
namespace Tyuiu.BocharovaES.Sprint5.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\Пользователь\AppData\Local\Temp\OutPutDataFileTask7V9.txt.";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
