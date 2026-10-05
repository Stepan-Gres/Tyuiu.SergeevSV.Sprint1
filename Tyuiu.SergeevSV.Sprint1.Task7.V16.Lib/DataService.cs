using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SergeevSV.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            double part1 = Math.Sin(Math.Sqrt(Math.Pow(x, 2)));
            double part2 = Math.Cos(Math.Pow(x, 2)) / (3.0 * Math.Pow(x, 3));
            double part3 = Math.Sin(Math.Sqrt(Math.Pow(x, 2) - 1.0));

            double result = part1 + part2 - part3;

            return Math.Round(result, 3);
        }
    }
}