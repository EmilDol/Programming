using System;

namespace SoftUni4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfStatists = int.Parse(Console.ReadLine());
            double priceOfCostume = double.Parse(Console.ReadLine());

            double money = budget - (budget * 0.1);

            if (countOfStatists > 150)
            {
                money -= ((priceOfCostume * countOfStatists) - ((priceOfCostume * countOfStatists) * 0.1));
            }
            else
            {
                money -= priceOfCostume * countOfStatists; 
            }

            if (money >= 0)
            {
                Console.WriteLine($"Action!\nWingard starts filming with {money:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!\nWingard needs {Math.Abs(money):f2} leva more.");
            }
        }
    }
}
