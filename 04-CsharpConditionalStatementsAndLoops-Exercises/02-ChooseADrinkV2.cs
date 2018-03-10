using System;

namespace Problem_2_Choose_a_Drink_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0.00;

            switch (profession)
            {
                case "Athlete":
                    price = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = 1.00;
                    break;
                case "SoftUni Student":
                    price = 1.70;
                    break;
                default:
                    price = 1.20;
                    break;
            }

            var total = quantity * price;

            Console.WriteLine($"The {profession} has to pay {total:f2}.");
        }
    }
}
