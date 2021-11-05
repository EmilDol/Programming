using System;

namespace SoftUni6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double moneyUsed = 0;

            switch (flower)
            {
                case "Roses": moneyUsed += countOfFlowers * 5;
                    if (countOfFlowers > 80)
                    {
                        moneyUsed -= moneyUsed * 0.1;
                    }
                    break;
                case "Dahlias":
                    moneyUsed += countOfFlowers * 3.8;
                    if (countOfFlowers > 90)
                    {
                        moneyUsed -= moneyUsed * 0.15;
                    }
                    break;
                case "Tulips":
                    moneyUsed += countOfFlowers * 2.8;
                    if (countOfFlowers > 80)
                    {
                        moneyUsed -= moneyUsed * 0.15;
                    }
                    break;
                case "Narcissus":
                    moneyUsed += countOfFlowers * 3;
                    if (countOfFlowers < 120)
                    {
                        moneyUsed += moneyUsed * 0.15;
                    }
                    break;
                case "Gladiolus":
                    moneyUsed += countOfFlowers * 2.5;
                    if (countOfFlowers < 80)
                    {
                        moneyUsed += moneyUsed * 0.2;
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            if (budget - moneyUsed >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {flower} and {(budget - moneyUsed):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget - moneyUsed):f2} leva more.");
            }
        }
    }
}
