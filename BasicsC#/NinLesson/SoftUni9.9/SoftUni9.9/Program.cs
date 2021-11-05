using System;

namespace SoftUni9._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int higth = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int sum = 0;
            int neededSpace;
            int freeSpace = width * lenght * higth;
            while (true)
            {
                try
                {
                    neededSpace = int.Parse(command);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"{freeSpace - sum} Cubic meters left.");
                    return;
                }
                sum += neededSpace;
                if (sum >= freeSpace)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace - sum)} Cubic meters more.");
                    return;
                }
                command = Console.ReadLine();
            }
        }
    }
}
