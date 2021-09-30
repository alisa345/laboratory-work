using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double s = a * b;
            double p = 2 * (a + b);
            Console.WriteLine($"Площадь : {s}  \nПериметр: {p}");
            Console.ReadKey();
        }
    }
}
