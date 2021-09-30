using System;

namespace ConsoleApp1
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double a2 = a * a * a; //8
            double a_help = a2 * a2; //64
            a2 = a_help * a_help * a2; // 256
            Console.WriteLine($"{a}^15 = {a2}");
            Console.ReadKey();
        }
    }
}
