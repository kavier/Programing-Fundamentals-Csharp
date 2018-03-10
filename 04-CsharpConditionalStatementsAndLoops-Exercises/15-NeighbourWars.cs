using System;

namespace Problem_15_Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int count = 0;
            string winner = "";

            int peshoHealth = 100;
            int goshoHealth = 100;

            for (int i = 1; ; i++)
            {
                count++;

                if (i % 2 != 0)
                {
                    goshoHealth -= peshoDamage;

                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                }
                else
                {
                    peshoHealth -= goshoDamage;

                    if (peshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }
                }

                if (peshoHealth <= 0)
                {
                    winner = "Gosho";
                    break;
                }
                else if (goshoHealth <= 0)
                {
                    winner = "Pesho";
                    break;
                }

                if (i%3==0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                
            }

            Console.WriteLine($"{winner} won in {count}th round.");
        }
    }
}
