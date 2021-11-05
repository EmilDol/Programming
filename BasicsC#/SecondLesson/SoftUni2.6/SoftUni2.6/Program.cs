using System;

namespace SoftUni2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            double priceOfCakes = people * cakes * days * 45;
            double priceOfWaffles = people * waffles * days * 5.8;
            double priceOfPnacakes = people * pancakes * days * 3.2;
            Console.WriteLine($"{(priceOfCakes+priceOfPnacakes+priceOfWaffles) - ((priceOfCakes + priceOfPnacakes + priceOfWaffles)*0.125):f2}");
        }
    }
}
