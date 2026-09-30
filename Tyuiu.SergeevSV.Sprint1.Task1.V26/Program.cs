using System;
using Tyuiu.SergeevSV.Sprint1.Task1.V26.Lib;

namespace Tyuiu.SergeevSV.Sprint1.Task1.V26;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Сергеев С. В. | АСОиУб-26-1";
        
        // Длина строки ровно 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнил: Сергеев Степан Васильевич | АСОиУб-26-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле 5 * x / (2 + y) и печатает его на экране.*");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x, y;

        Console.Write("Введите значение X: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение Y: ");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        // Вызов вашего метода логики из библиотеки
        Console.WriteLine(ds.Calculate(x, y));

        Console.ReadLine();
    }
}
