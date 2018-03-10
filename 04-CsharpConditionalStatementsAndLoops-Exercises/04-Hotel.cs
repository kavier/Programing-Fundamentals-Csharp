using System;

namespace Problem_04_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double studioPrice = 0.00;
            double doublePrice = 0.00;
            double suitePrice = 0.00;
            double studioFreeDay = 0.00;
            double studioDiscount = 1.00;
            double suiteDiscount = 1.00;
            double doubleDiscount = 1.00;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    break;
                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    break;
            }

            if (nights > 14)
            {
                if (month == "June")
                {
                    doubleDiscount = 0.90;
                }
                else if (month == "July" || month == "August" || month == "December")
                {
                    suiteDiscount = 0.85;
                }
                if (month == "May")
                {
                    studioDiscount = 0.95;
                }
                else if (month == "October")
                {
                    studioDiscount = 0.95;
                    studioFreeDay = 1;
                }
                else if (month == "September")
                {
                    studioFreeDay = 1;
                    doubleDiscount = 0.90;
                }
            }
            else if (nights > 7)
            {
                if (month == "May")
                {
                    studioDiscount = 0.95;
                }
                else if (month == "October")
                {
                    studioDiscount = 0.95;
                    studioFreeDay = 1;
                }
                else if (month == "September")
                {
                    studioFreeDay = 1;
                }
            }

            double studioTotal = (nights - studioFreeDay) * studioPrice * studioDiscount;
            double doubleTotal = nights * doublePrice * doubleDiscount;
            double suiteTotal = nights * suitePrice * suiteDiscount;

            Console.WriteLine($"Studio: {studioTotal:f2} lv.");
            Console.WriteLine($"Double: {doubleTotal:f2} lv.");
            Console.WriteLine($"Suite: {suiteTotal:f2} lv.");

        }
    }
}
