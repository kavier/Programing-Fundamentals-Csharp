using System;

namespace Problem_03_Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupSize = double.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double price = 0.00;
            double discount = 0.00;
            double packagePrice = 0.00;
            string hallName = "";

            switch (package)
            {
                case "Gold":
                    discount = 0.10;
                    packagePrice = 750;
                    break;
                case "Platinum":
                    discount = 0.15;
                    packagePrice = 1000;
                    break;
                default:
                    discount = 0.05;
                    packagePrice = 500;
                    break;
            }
        
             if (groupSize <= 50)
            {
                price = 2500;
                hallName = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                price = 5000;
                hallName = "Terrace";
            }
            else if (groupSize <= 120)
            {
                price = 7500;
                hallName = "Great Hall";
            }

            var subTotal = (price + packagePrice);
            var total = subTotal - (subTotal * discount);
            var pricePerPerson = total / groupSize;

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
        }
    }
}