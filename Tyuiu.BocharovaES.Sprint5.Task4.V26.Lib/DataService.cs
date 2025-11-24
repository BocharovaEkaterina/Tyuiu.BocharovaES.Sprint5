using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BocharovaES.Sprint5.Task4.V26.Lib
{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX.Replace('.', ','));
            double res =(Math.Pow(x, 3) + Math.Sin(x)) * (Math.Cos(x));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
