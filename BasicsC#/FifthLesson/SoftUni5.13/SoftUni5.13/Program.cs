using System;

namespace SoftUni5._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string ocenka = Console.ReadLine();
            double price = 0;

            switch (type)
            {
                case "room for one person":
                    price = (days - 1) * 18;
                    break;

                case "apartment":
                    price = (days - 1) * 25;
                    if (days <= 10)
                    {
                        price -= price * 0.3;
                    }
                    else if (days > 10 && days <= 15)
                    {
                        price -= price * 0.35;
                    }
                    else if (days > 15)
                    {
                        price -= price * 0.5;
                    }
                    break;
                case "president apartment":
                    price = (days - 1) * 35;
                    if (days <= 10)
                    {
                        price -= price * 0.1;
                    }
                    else if (days > 10 && days <= 15)
                    {
                        price -= price * 0.15;
                    }
                    else if (days > 15)
                    {
                        price -= price * 0.20;
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            if (ocenka == "positive")
            {
                price += price * 0.25;
            }
            else
            {
                price -= price * 0.1;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
