using System;

namespace Problem_02_Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double spent = 0.00;
            double gamePrice = 0.00;
            bool check = true;
            bool gameCheck = true;

            for (int i = 1; ; i++)
            {
                string gameName = Console.ReadLine();

                gameCheck = true;
                check = true;

                if (gameName != "Game Time")
                {
                    switch (gameName)
                    {
                        case "OutFall 4":
                            gamePrice = 39.99;
                            break;
                        case "CS: OG":
                            gamePrice = 15.99;
                            break;
                        case "Zplinter Zell":
                            gamePrice = 19.99;
                            break;
                        case "Honored 2":
                            gamePrice = 59.99;
                            break;
                        case "RoverWatch":
                            gamePrice = 29.99;
                            break;
                        case "RoverWatch Origins Edition":
                            gamePrice = 39.99;
                            break;
                        default:
                            gamePrice = 0.00;
                            gameCheck = false;
                            check = false;
                            break;
                    }

                    spent += gamePrice;

                    if(spent > budget && gameCheck == true)
                    {
                        Console.WriteLine("Too Expensive");
                        spent -= gamePrice;

                        check = false;
                    }

                    if (gameCheck == true && check == true)
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }

                    if (gameCheck == false && check == false)
                    {
                        Console.WriteLine("Not Found");
                    }

                }
                else
                {
                    if (budget>spent)
                    {
                        double result = budget - spent;

                        Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${result:f2}");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Out of money!");

                        break;
                    }
                }
            }
        }
    }
}
