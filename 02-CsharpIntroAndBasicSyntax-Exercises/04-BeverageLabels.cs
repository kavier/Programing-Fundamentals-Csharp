using System;

namespace Problem_4._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var size = double.Parse(Console.ReadLine());
            var caloriesPer100 = double.Parse(Console.ReadLine());
            var sugarsPer100 = double.Parse(Console.ReadLine());

            var calories = (caloriesPer100 / 100) * size;
            var sugars = (sugarsPer100 / 100) * size;

            Console.WriteLine($"{size}ml {name}:");
            Console.WriteLine($"{calories}kcal, {sugars}g sugars");

        }
    }
}
