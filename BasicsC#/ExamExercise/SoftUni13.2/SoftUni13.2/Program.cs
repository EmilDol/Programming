using System;

namespace SoftUni13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double SecondsPreMeter = double.Parse(Console.ReadLine());
            double totalTIme;
            double deley = Math.Floor(distance / 50) * 30;
            totalTIme = distance * SecondsPreMeter;
            totalTIme += deley;
            if (totalTIme<record)
            {
                Console.WriteLine($"Yes! The new record is {totalTIme:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {(totalTIme-record):f2} seconds slower.");
            }
        }
    }
}
