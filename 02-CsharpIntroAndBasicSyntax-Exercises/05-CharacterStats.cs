using System;

namespace Problem_5._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var healthFull = int.Parse(Console.ReadLine());
            var healthEmpty = int.Parse(Console.ReadLine());
            var energyFull = int.Parse(Console.ReadLine());
            var energyEmpty = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', healthFull), new string('.', healthEmpty - healthFull));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', energyFull), new string('.', energyEmpty - energyFull));

        }
    }
}
