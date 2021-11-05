using System;

namespace SoftUni2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double hours = pages(double) / pagesPerHour;
            Console.WriteLine(hours / days);
        }
    }
}
