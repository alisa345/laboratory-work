using System;

namespace ConsoleApp1
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 3 * Math.Pow(x, 6) - 6 * Math.Pow(x, 2) - 7;
            Console.WriteLine($"y = {Math.Round(y, 4)}");
            Console.ReadKey();
        }
    }
}
