using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            Console.Write("Введите диаметр d: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double l = PI * d;
            Console.WriteLine($"Длина окружности : {l}");
            Console.ReadKey();
        }
    }
}
