using System;

namespace Problem_05_Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string newEnd = "";

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                newEnd = "ies";
            }
            else if (word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z")|| word.EndsWith("ch") || word.EndsWith("sh"))
            {
                newEnd = "es";

            }
            else
            {
                newEnd = "s";

            }
            Console.WriteLine($"{word}{newEnd}");
        }
    }
}
