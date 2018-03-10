using System;

namespace Problem_03_Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double result = width * height / 1000000;
            result = Math.Round(result, 1);

            Console.WriteLine($"{width}x{height} => {result}MP");

        }
    }
}
