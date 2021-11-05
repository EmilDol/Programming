using System;

namespace SoftUni4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double secondsRecord = double.Parse(Console.ReadLine());
            int meters = int.Parse(Console.ReadLine());
            double metersPerSecond = double.Parse(Console.ReadLine());
            const double DELAY = 12.5;
            double secondsIvancho = meters * metersPerSecond;

            secondsIvancho += DELAY * (meters / 15);

            if (secondsIvancho < secondsRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {secondsIvancho:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(secondsIvancho - secondsRecord):f2} seconds slower.");
            }
        }
    }
}
