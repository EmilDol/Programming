using System;

namespace SoftUni10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            string activity;
            double moneyInUse;
            int counterDays = 0;
            int counterSpendStrike = 0;
            while (true)
            {
                counterDays++;
                activity = Console.ReadLine();
                moneyInUse = double.Parse(Console.ReadLine());
                if (activity == "save")
                {
                    ownedMoney += moneyInUse;
                    counterSpendStrike = 0;
                }
                else if (activity == "spend")
                {
                    ownedMoney -= moneyInUse;
                    counterSpendStrike++;
                }
                if (ownedMoney < 0)
                {
                    ownedMoney = 0;
                }
                if (counterSpendStrike >= 5)
                {
                    Console.WriteLine($"You can't save the money.\n{counterDays}");
                    return;
                }
                if (ownedMoney >= neededMoney)
                {
                    Console.WriteLine($"You saved the money for {counterDays} days.");
                    return;
                }
            }
        }
    }
}
