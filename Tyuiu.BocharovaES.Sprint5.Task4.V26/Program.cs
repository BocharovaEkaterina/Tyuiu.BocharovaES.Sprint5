using Tyuiu.BocharovaES.Sprint5.Task4.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Дан файл С:|DataSprint5|InPutDataFileTask4V0.txt, в котором есть        *");
        Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо Х*");
        Console.WriteLine("* в формуле y=(x^3+sin(x))cos(x). Вычислить значение по формуле и вернуть *");
        Console.WriteLine("* олученный результат на консоль.                                         *");
        Console.WriteLine("*                                                                         *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask4V26.txt";

        Console.WriteLine("Данные находятся в файле " + path);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);

        Console.WriteLine(res);
        Console.ReadKey();
    }
}