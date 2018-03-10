using System;


namespace Problem_08_SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = 0; i < numberOfLetters; i++)
            {
                int letter = int.Parse(Console.ReadLine());

                if (letter == 0)
                {
                    result += " ";
                }
                else
                {
                    int toString = letter.ToString().Length;
                    int digit = letter % 10;
                    int index = (digit - 2) * 3;

                    if (digit == 8 || digit == 9)
                    {
                        index++;
                    }

                    int letterIndex = index + toString - 1;
             char parsedLetter = (char)(97 + letterIndex);
                    result += parsedLetter;
                }

             
            }
            Console.WriteLine(result);
        }
    }
}
