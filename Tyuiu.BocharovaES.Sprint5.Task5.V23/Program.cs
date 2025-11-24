using Tyuiu.BocharovaES.Sprint5.Task5.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Дан файл С:|DataSprint5|InPutDataFileTask5V23.txt, в котором есть       *");
        Console.WriteLine("* набор значений. Найти минимальное вещественное число в файле. Полученный*");
        Console.WriteLine("* результат вывести на консоль. У вещественных значений округлить до трёх *");
        Console.WriteLine("* знаков после запятой.                                                   *");
        Console.WriteLine("*                                                                         *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask5V23.txt";

        Console.WriteLine("Данные находятся в файле " + path);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);

        Console.WriteLine(res);
        Console.ReadKey();
    }
}