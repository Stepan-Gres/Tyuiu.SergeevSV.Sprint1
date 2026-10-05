using System;
using System.Globalization;
using Tyuiu.SergeevSV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.SergeevSV.Sprint1.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Сергеев С. В. | АСОиУб-26-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая находит расстояние между двумя точками      *");
            Console.WriteLine("* с заданными координатами. Ответ привести к целому с помощью Convert.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите x1: ");
            double x1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Введите y1: ");
            double y1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Введите x2: ");
            double x2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Введите y2: ");
            double y2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками (целое число) = {res}");

            Console.ReadLine();
        }
    }
}
