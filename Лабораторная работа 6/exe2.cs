using System;

namespace ConsoleApp1
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите C: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double num = a;
            a = c;
            c = b;
            b = num;
            Console.WriteLine($"A: {a} \nB: {b} \nC: {c}");
            Console.ReadKey();
        }
    }
}
