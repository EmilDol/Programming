using System;

namespace SoftUni9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            double num = 0;
            double sum = 0;
            while (true)
            {
                command = Console.ReadLine();
                try
                {
                    num = double.Parse(command);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Total: {sum}");
                    return;
                }
                if (num < 0)
                {
                    Console.WriteLine($"Invalid operation!\nTotal: {sum}");
                    return;
                }
                sum += num;
                Console.WriteLine($"Increase: {num:f2}");
            }
        }
    }
}
