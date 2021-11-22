using System;

namespace PracticeTask6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            Int64 x = Convert.ToInt64(Console.ReadLine());
            Console.Write("Введите значение y: ");
            Int64 y = Convert.ToInt64(Console.ReadLine());
            double a = (Math.Log(Math.Pow(y, - (Math.Sqrt((Math.Abs(x))))))) * (Math.Cos(x) + (Math.Exp((x + y))));
            Console.WriteLine("{0:F}", a);
        }
    }
}
