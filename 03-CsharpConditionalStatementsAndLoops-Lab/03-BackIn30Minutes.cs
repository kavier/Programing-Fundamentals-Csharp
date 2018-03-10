using System;

namespace Problem_3._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine()) + 30;

            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");

            }
        }
    }
}
