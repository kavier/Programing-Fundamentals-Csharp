using System;

namespace Problem_12._Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");


            }
        }
    }
}
