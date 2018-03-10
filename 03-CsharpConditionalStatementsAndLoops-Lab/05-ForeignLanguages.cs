using System;

namespace Problem_5._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine().ToLower();

            switch (country)
            {
                case "england":
                case "usa":
                    Console.WriteLine("English");
                    break;
                case "spain":
                case "mexico":
                case "argentina":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
