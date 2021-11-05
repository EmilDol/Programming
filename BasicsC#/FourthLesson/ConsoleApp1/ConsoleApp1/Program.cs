using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSeconds = int.Parse(Console.ReadLine());
            int secondSeconds = int.Parse(Console.ReadLine());
            int thirdSeconds = int.Parse(Console.ReadLine());

            int seconds = (firstSeconds + secondSeconds + thirdSeconds) % 60;
            int minutes = (firstSeconds + secondSeconds + thirdSeconds) / 60;
            if (seconds >= 10)
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
        }
    }
}
