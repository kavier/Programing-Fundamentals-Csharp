using System;

namespace Problem_01_x
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int rols = (input - 1)/2;
            int count = 0;

            for (int i = 0; i < rols; i++)
            {
                count++;
                Console.WriteLine("{0}x{1} {1}x{0}", new string(' ', i), new string(' ', (input - 3)/2 - i));
                
            }

            Console.WriteLine("{0}x", new string(' ', rols));

             for (int i = 1; i <= rols; i++)
            {
                Console.WriteLine("{0}x{1} {1}x{0}", new string(' ', count - i), new string(' ', i-1));
            }
        }
    }
}
