using System;

namespace Problem_2._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = double.Parse(Console.ReadLine());
            var number2 = double.Parse(Console.ReadLine());

            var area = number1 * number2;

            Console.WriteLine($"{area:f2}");

        }
    }
}