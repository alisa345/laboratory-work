using System;

namespace ConsoleApp1
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double a2 = a * a;
            a2 = a2 * a2;
            a2 = a2 * a2; 
            Console.WriteLine($"{a}^8 = {a2}");
            Console.ReadKey();
        }
    }
}
