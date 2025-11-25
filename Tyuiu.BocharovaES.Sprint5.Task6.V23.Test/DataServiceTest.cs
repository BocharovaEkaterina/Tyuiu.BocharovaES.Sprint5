using System.IO;
using Tyuiu.BocharovaES.Sprint5.Task6.V23.Lib;
namespace Tyuiu.BocharovaES.Sprint5.Task6.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V23.txt";

            var res = ds.LoadFromDataFile(path);
            int wait =7;
            Assert.AreEqual(wait, res);
        }
    }
}
