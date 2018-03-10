using System;

namespace Problem_14_Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());

            for (char i = char1; i <= char2; i++)
            {
                for (char j = char1; j <= char2; j++)
                {
                    for (char k = char1; k <= char2; k++)
                    {
                        if (i != char3 && j != char3 && k != char3)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
