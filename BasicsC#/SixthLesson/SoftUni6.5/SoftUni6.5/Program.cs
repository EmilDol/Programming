using System;

namespace SoftUni6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination;

            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
            }
            else
            {
                destination = "Europe";
            }
            Console.WriteLine($"Somewhere in {destination}");
            if (season == "summer" && destination == "Bulgaria")
            {
                Console.WriteLine($"Camp - {(budget * 0.3):f2}");
                return;
            }
            if (season == "winter" && destination == "Bulgaria")
            {
                Console.WriteLine($"Hotel - {(budget * 0.7):f2}");
                return;
            }
            if (season == "summer" && destination == "Balkans")
            {
                Console.WriteLine($"Camp - {(budget * 0.4):f2}");
                return;
            }
            if (season == "winter" && destination == "Balkans")
            {
                Console.WriteLine($"Hotel - {(budget * 0.8):f2}");
                return;
            }
            if (destination == "Europe")
            {
                Console.WriteLine($"Hotel - {(budget * 0.9):f2}");
                return;
            }
        }
    }
}
