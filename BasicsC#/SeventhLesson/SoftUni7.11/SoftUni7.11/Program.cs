using System;

namespace SoftUni7._11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int lilyAge = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            int moneyGifted = 10;
            int countOfToys = 0;
            double money = 0;
            for (int i = 1; i <= lilyAge; i++)
            {
                if (i % 2 == 0)
                {
                    money += moneyGifted - 1;
                    moneyGifted += 10;
                }
                else
                {
                    countOfToys++;
                }
            }
            money += countOfToys * toysPrice;
            if (money >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {(money - washingMachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachinePrice - money):f2}");
            }
        }
    }
}
