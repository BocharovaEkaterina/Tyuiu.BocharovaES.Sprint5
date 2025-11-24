using Tyuiu.BocharovaES.Sprint5.Task3.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнила: Бочарова Е. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнила: Бочарова Екатерина Сергеевна | ИИПб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Дано выражение F(x) = 2x^3 + 1/2x^2 - 3.5x +2, вычислить его значение   *");
        Console.WriteLine("* при x = 2, результат сохранить в бинарный файл OutPutFileTask3.bin и    *");
        Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.             *");
        Console.WriteLine("*                                                                         *");

        int x = 2; 


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("x = " + x);

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}