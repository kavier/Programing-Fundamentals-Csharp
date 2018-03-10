using System;

namespace Problem_08_Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            int promenliva = 0;
            int calories = 0;

            for (int i = 0; i < numberOfIngredients; i++)
            {
               string ingredient = Console.ReadLine().ToLower();

                if(ingredient == "cheese")
                {
                    promenliva = 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    promenliva = 150;
                }
                else if (ingredient == "salami")
                {
                    promenliva = 600;
                }
                else if (ingredient == "pepper")
                {
                    promenliva = 50;
                }
                else
                {
                    promenliva = 0;
                }

                calories += promenliva;
            }

            Console.WriteLine($"Total calories: {calories}");

        }
    }
}
