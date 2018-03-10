using System;

namespace Problem_2._Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var result = number1 + number2;

            Console.WriteLine($"{number1} + {number2} = {result}");
        }
    }
}