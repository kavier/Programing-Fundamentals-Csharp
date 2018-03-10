using System;

namespace Problem_13_Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());

            int count = 0;
            int previousNum = 0;

            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    int calculate = (i + j);
                    count++;

                    previousNum = calculate;

                    if (previousNum == magicalNum)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicalNum}");
                        return;
                    }
                }
            }

            if (previousNum != magicalNum)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicalNum}");

            }
        }
    }
}
