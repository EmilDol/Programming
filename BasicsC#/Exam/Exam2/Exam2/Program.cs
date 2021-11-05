using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyPerDay = double.Parse(Console.ReadLine());
            double profitPerDay = double.Parse(Console.ReadLine());
            double costPerDay = double.Parse(Console.ReadLine());
            double costOfPresent = double.Parse(Console.ReadLine());
            double totalMoneySaved = moneyPerDay * 5;
            totalMoneySaved += profitPerDay * 5;
            totalMoneySaved -= costPerDay;
            if (totalMoneySaved >= costOfPresent)
            {
                Console.WriteLine($"Profit: {(totalMoneySaved):f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {(costOfPresent - totalMoneySaved):f2} BGN.");
            }
        }
    }
}
