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
            double sum = a + b;
            double diff = Math.Abs(a - b);
            double prod = a * b;
            double quot = Math.Round(Math.Pow(a, 2) / Math.Pow(b, 2), 4);
            Console.WriteLine($"Сумма: {sum} \nРазность: {diff} \nПроизведение {prod} \nЧастное их квадратов {quot}");
            Console.ReadKey();
        }
    }
}
