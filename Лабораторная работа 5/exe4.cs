using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double a = Math.Abs(y1 - y2);
            double b = Math.Abs(x1 - x2);
            double s = a * b;
            double p = (a + b) * 2;
            Console.WriteLine($"Площадь: {s} \nПериметр: {p}");
            Console.ReadKey();
        }
    }
}
