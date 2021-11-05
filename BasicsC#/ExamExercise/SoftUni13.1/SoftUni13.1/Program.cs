using System;

namespace SoftUni13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceZala = double.Parse(Console.ReadLine());
            double priceStatues = 0.7 * priceZala;
            double priceMandja = 0.85 * priceStatues;
            double priceZvuk = 0.5 * priceMandja;
            Console.WriteLine($"{(priceMandja + priceStatues + priceZala + priceZvuk):f2}");
        }
    }
}
