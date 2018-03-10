using System;

namespace Problem_11_5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit1 = int.Parse(Console.ReadLine());
            int digit2 = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int n1 = digit1; n1 < digit2; n1++)
            {
                for (int n2 = digit1; n2 < digit2; n2++)
                {
                    for (int n3 = digit1; n3 < digit2; n3++)
                    {
                        for (int n4 = digit1; n4 <= digit2; n4++)
                        {
                            for (int n5 = digit1; n5 <= digit2; n5++)
                            {
                                if (digit1 <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= digit2)
                                {
                                    Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
