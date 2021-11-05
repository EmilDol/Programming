using System;

namespace SoftUni3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PUZZLE_PRICE = 2.60;
            const double DOLL_PRICE = 3;
            const double TEDDY_BEAR_PRICE = 4.10;
            const double MINION_PRICE = 8.20;
            const double TRUCK_PRICE = 2;

            double neededMoney = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int teddyBearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            double totalSum = (puzzleCount * PUZZLE_PRICE) + (dollCount * DOLL_PRICE) + (teddyBearCount * TEDDY_BEAR_PRICE) + (minionCount * MINION_PRICE) + (truckCount * TRUCK_PRICE);
            if (puzzleCount + dollCount + truckCount + minionCount + teddyBearCount >= 50)
            {
                totalSum -= totalSum * 0.25;
            }
            totalSum -= totalSum * 0.10;

            if (totalSum >= neededMoney)
            {
                Console.WriteLine($"Yes! {(totalSum - neededMoney):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(neededMoney - totalSum):f2} lv needed.");
            }
        }
    }
}
