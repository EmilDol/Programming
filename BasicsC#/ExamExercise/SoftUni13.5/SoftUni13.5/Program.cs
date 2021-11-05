using System;

namespace SoftUni13._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int heigth = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int nonPaintingPercent = int.Parse(Console.ReadLine());
            string input;
            int litars = 0;
            double totalSpace = heigth * length * 4;
            totalSpace -= totalSpace * (nonPaintingPercent / 100.00);
            totalSpace = Math.Ceiling(totalSpace); // !!!
            while (true)
            {
                input = Console.ReadLine();
                try
                {
                    litars = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"{totalSpace} quadratic m left.");
                    return;
                }
                int LITARS = litars;
                for (int i = 0; i < LITARS; i++)
                {
                    if (totalSpace <= 0 && litars > 0)
                    {
                        Console.WriteLine($"All walls are painted and you have {litars} l paint left!");
                        return;
                    }
                    else if (totalSpace <= 0 && litars == 0)
                    {
                        Console.WriteLine($"All walls are painted! Great job, Pesho!");
                        return;
                    }
                    totalSpace--;
                    litars--;

                }

            }

        }
    }
}
