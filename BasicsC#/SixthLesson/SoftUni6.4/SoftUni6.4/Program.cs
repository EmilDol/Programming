using System;

namespace SoftUni6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countOfRibars = int.Parse(Console.ReadLine());

            double moneyUsed = 0;

            switch (season)
            {
                case "Spring":
                    moneyUsed += 3500;
                    if (countOfRibars <= 6)
                    {
                        moneyUsed -= moneyUsed * 0.1;
                    }
                    else if (countOfRibars > 6 && countOfRibars <= 11)
                    {
                        moneyUsed -= moneyUsed * 0.15;
                    }
                    else if (countOfRibars >= 12)
                    {
                        moneyUsed -= moneyUsed * 0.25;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    moneyUsed += 4200;
                    if (countOfRibars <= 6)
                    {
                        moneyUsed -= moneyUsed * 0.1;
                    }
                    else if (countOfRibars > 6 && countOfRibars <= 11)
                    {
                        moneyUsed -= moneyUsed * 0.15;
                    }
                    else if (countOfRibars >= 12)
                    {
                        moneyUsed -= moneyUsed * 0.25;
                    }
                    break;
                case "Winter":
                    moneyUsed += 2600;
                    if (countOfRibars <= 6)
                    {
                        moneyUsed -= moneyUsed * 0.1;
                    }
                    else if (countOfRibars > 6 && countOfRibars <= 11)
                    {
                        moneyUsed -= moneyUsed * 0.15;
                    }
                    else if (countOfRibars >= 12)
                    {
                        moneyUsed -= moneyUsed * 0.25;
                    }
                    break;

                default:
                    break;
            }
            if (season != "Autumn" && countOfRibars % 2 == 0)
            {
                moneyUsed -= moneyUsed * 0.05;
            }
            if (budget - moneyUsed >= 0)
            {
                Console.WriteLine($"Yes! You have {(budget - moneyUsed):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - moneyUsed):f2} leva.");
            }
        }
    }
}
