using System;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int transportCards = int.Parse(Console.ReadLine());
            int museumTickets = int.Parse(Console.ReadLine());
            double totalSum = 0;
            double sumPerPerson = (nights * 20) + (transportCards * 1.6) + (museumTickets * 6);
            totalSum = sumPerPerson * people;
            totalSum += 0.25 * totalSum;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
