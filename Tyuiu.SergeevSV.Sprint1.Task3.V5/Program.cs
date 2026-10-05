using System;
using System.Globalization;
using Tyuiu.SergeevSV.Sprint1.Task3.V5.Lib;

namespace Tyuiu.SergeevSV.Sprint1.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Сергеев С. В. | АСОиУб-26-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления расстояния между населенными пунктами,    *");
            Console.WriteLine("* изображенными на карте. Ответ округлить до 3 знаков после запятой.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите масштаб карты (количество км в одном см): ");
            double mapScale = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Введите расстояние между точками на карте (см): ");
            double distanceBetweenPoints = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.DistanceLength(mapScale, distanceBetweenPoints);
            Console.WriteLine($"Расстояние между населенными пунктами = {res} км.");

            Console.ReadLine();
        }
    }
}

