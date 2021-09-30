using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = (a + b) / 2;
            Console.WriteLine($"Среднее арифметическое: {c}");
            Console.ReadKey();
        }
    }
}
