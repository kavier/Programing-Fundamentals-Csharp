using System;

namespace Problem_06_DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                       
                            
                                count++;

                        if (i+j+k >= sum)
                        {
                            Console.Write($"O{i}{j}{k}O ".Replace('1', 'A').Replace('2','C').Replace('3','G').Replace('4','T'));
                        }
                        else
                        {
                            Console.Write($"X{i}{j}{k}X ".Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T'));

                        }

                        if (count%4==0)
                                {
                                    Console.WriteLine();
                                }
                                              
                    }
                }
            }
        }
    }
}
