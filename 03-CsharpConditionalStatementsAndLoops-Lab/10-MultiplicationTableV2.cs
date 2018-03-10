using System;

namespace Problem_10._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());

            if (n2 <= 10)
            {
                for (int i = n2; i <= 10; i++)
                {                
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
            else
            {
                Console.WriteLine($"{n} X {n2} = {n * n2}");

            }

        }
    }
}
