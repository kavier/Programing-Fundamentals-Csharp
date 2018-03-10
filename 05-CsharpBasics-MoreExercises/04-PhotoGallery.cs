using System;

namespace Problem_04_Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSize = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year:d4} {hours:d2}:{minutes:d2}");

            if (photoSize > 999999)
            {
                double result = photoSize / 1000000;
                result = Math.Round(result, 1);
                Console.WriteLine($"Size: {result}MB");
            }
            else if (photoSize > 999)
            {
                double result = photoSize / 1000;
                result = Math.Round(result, 0);
                Console.WriteLine($"Size: {result}KB");
            }
            else if (photoSize <= 999)
            {
                double result = photoSize;
                result = Math.Round(result, 0);
                Console.WriteLine($"Size: {result}B");
            }

            if (width == height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
            else if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");

            }
            else
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");

            }
        }
    }
}
