using System;

namespace SoftUni2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double malinas = double.Parse(Console.ReadLine());
            double strawberries = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            totalPrice += strawberries * strawberriesPrice;
            totalPrice += malinas * (strawberriesPrice / 2);
            totalPrice += bananas * ((strawberriesPrice / 2) - (strawberriesPrice / 2) * 0.8);
            totalPrice += oranges * ((strawberriesPrice / 2) - (strawberriesPrice / 2) * 0.4);
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
