using System;

namespace Problem_07_Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredients = "";

            for (int i = 0; i < 21; i++)
            {
                ingredients = Console.ReadLine();

                    if (ingredients != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredients}.");

                }
                    else
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }
            }


        }
    }
}
