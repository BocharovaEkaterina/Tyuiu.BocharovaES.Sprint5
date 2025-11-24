using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BocharovaES.Sprint5.Task3.V5.Lib
{
    public class DataService : ISprint5Task3V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });
            double z = 2*Math.Pow(x,3) + 0.5*x*x -3.5*x + 2 ;
            z = Math.Round(z, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(z));
            }
            return path;
        }
    }
}
