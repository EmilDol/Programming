using System;

namespace SpiceFustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSpice = int.Parse(Console.ReadLine());
            int totalGathered = 0;
            int days = 0;
            while (countSpice >= 100)
            {
                totalGathered += countSpice-26;
                countSpice -= 10;
                days++;
            }
            totalGathered -= 26;
            if (totalGathered < 0)
            {
                totalGathered = 0;
            }
            Console.WriteLine($"{days}\n{totalGathered}");
        }
    }
}
