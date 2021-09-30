using System;

namespace ConsoleApp1
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 4 * Math.Pow(x - 3, 6) - 7 * Math.Pow(x - 3, 3) + 2;
            Console.WriteLine($"y = {Math.Round(y, 4)}");
            Console.ReadKey();
        }
    }
}
