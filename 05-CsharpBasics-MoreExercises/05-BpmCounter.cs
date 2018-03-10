using System;

namespace Problem_05_BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int bpm = int.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4;
            bars = Math.Round(bars, 1);
            double time = 0.0;
            double minutes = 0.0;

            double seconds = 60 * numberOfBeats / bpm;
            seconds = Math.Floor(seconds);

            if (seconds >= 60)
            {
                
                minutes = seconds/60;
                minutes = Math.Floor(minutes);
                time = seconds - (minutes * 60);
            }
            else
            {
                time = seconds;
            }

            Console.WriteLine($"{bars} bars - {minutes}m {time}s");

        }
    }
}
