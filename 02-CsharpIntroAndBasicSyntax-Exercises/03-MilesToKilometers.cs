using System;

namespace Problem_3._Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = double.Parse(Console.ReadLine());

            var kilomerters = miles * 1.60934;

            Console.WriteLine($"{kilomerters:f2}");

        }
    }
}
