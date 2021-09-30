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
            Console.Write("Введите c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double ac = Math.Abs(a - c);
            double bc = Math.Abs(b - c);
            double sum = ac + bc;
            Console.WriteLine($"Длина AC: {ac} \nДлина BC: {bc}\nСумма: {sum}");
            Console.ReadKey();
        }
    }
}
