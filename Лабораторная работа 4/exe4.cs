using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
            Console.Write("Введите b: ");
            double b = Math.Pow(Convert.ToDouble(Console.ReadLine()), 2);
            double sum = a + b;
            double diff = Math.Abs(a - b);
            double prod = a * b;
            double quot = Math.Round(a / b, 4);
            Console.WriteLine($"Сумма: {sum} \nРазность: {diff} \nПроизведение: {prod} \nЧастное: {quot}");
            Console.ReadKey();
        }
    }
}
