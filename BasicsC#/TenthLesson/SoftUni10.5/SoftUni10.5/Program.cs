using System;

namespace SoftUni10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyIn = double.Parse(Console.ReadLine());
            int coins = 0;
            while (moneyIn > 0)
            {
                if (moneyIn >= 2)
                {
                    coins++;
                    moneyIn -= 2;
                    moneyIn = Math.Round(moneyIn, 2);
                }

                else if (moneyIn >= 1)
                {
                    coins++;
                    moneyIn--;
                    moneyIn = Math.Round(moneyIn, 2);
                }

                else if (moneyIn >= 0.5)
                {
                    coins++;
                    moneyIn -= 0.5;
                    moneyIn = Math.Round(moneyIn, 2);
                }
                
                else if (moneyIn >= 0.2)
                {
                    coins++;
                    moneyIn -= 0.2;
                    moneyIn = Math.Round(moneyIn, 2);
                }
                
                else if (moneyIn >= 0.1)
                {
                    coins++;
                    moneyIn -= 0.1;
                    moneyIn = Math.Round(moneyIn, 2);
                }
                
                else if (moneyIn >= 0.05)
                {
                    coins++;
                    moneyIn -= 0.05;
                    moneyIn = Math.Round(moneyIn, 2);
                }
                
                else if (moneyIn >= 0.02)
                {
                    coins++;
                    moneyIn-=0.02;
                    moneyIn = Math.Round(moneyIn, 2);
                }
                
                else if (moneyIn >= 0.01)
                {
                    coins++;
                    moneyIn-=0.01;
                    moneyIn = Math.Round(moneyIn, 2);
                }
            }
            Console.WriteLine(coins);
        }
    }
}
