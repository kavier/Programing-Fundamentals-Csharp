using System;

namespace Problem_12_Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());

            int count = 0;
            int previousNum = 0;

            for (int i = num1; i >= 1; i--)
            {
                for (int j = 1; j <= num2; j++)
                {
                    int calculate = previousNum + 3 * (i * j);
                    count++;

                    previousNum = calculate;

                    if (previousNum >= boundary)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {previousNum} >= {boundary}");
                        return;
                    }
                }
            }

            if (previousNum<boundary)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {previousNum}");

            }
        }
    }
}
