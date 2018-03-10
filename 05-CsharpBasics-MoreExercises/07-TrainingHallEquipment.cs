using System;

namespace Problem_07_Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int items = int.Parse(Console.ReadLine());
            double spent = 0.00;

            for (int i = 0; i < items; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                double itemPCS = double.Parse(Console.ReadLine());

                double spentForProduct = itemPCS * itemPrice;

                spent += spentForProduct;

                if (itemPCS>1)
                {
                    Console.WriteLine($"Adding {itemPCS} {itemName}s to cart.");

                }
                else
                {
                    Console.WriteLine($"Adding {itemPCS} {itemName} to cart.");

                }
            }

            Console.WriteLine($"Subtotal: ${spent:f2}");

            if (budget >= spent)
            {
                Console.WriteLine($"Money left: ${budget - spent:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${spent - budget:f2} more.");

            }
        }
    }
}
