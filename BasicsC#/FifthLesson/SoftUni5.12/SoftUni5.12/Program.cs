using System;

namespace SoftUni5._12
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double buy = double.Parse(Console.ReadLine());
            switch (town)
            {
                case "Sofia":
                    if (buy >= 0 && buy <= 500)
                    {
                        Console.WriteLine($"{(buy * 0.05):f2}");
                    }
                    else if (buy > 500 && buy <= 1000)
                    {
                        Console.WriteLine($"{(buy * 0.07):f2}");
                    }
                    else if (buy > 1000 && buy <= 10000)
                    {
                        Console.WriteLine($"{(buy * 0.08):f2}");
                    }
                    else if (buy > 10000)
                    {
                        Console.WriteLine($"{(buy * 0.12):f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Varna":
                    if (buy >= 0 && buy <= 500)
                    {
                        Console.WriteLine($"{(buy * 0.045):f2}");
                    }
                    else if (buy > 500 && buy <= 1000)
                    {
                        Console.WriteLine($"{(buy * 0.075):f2}");
                    }
                    else if (buy > 1000 && buy <= 10000)
                    {
                        Console.WriteLine($"{(buy * 0.1):f2}");
                    }
                    else if (buy > 10000)
                    {
                        Console.WriteLine($"{(buy * 0.13):f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                case "Plovdiv":
                    if (buy >= 0 && buy <= 500)
                    {
                        Console.WriteLine($"{(buy * 0.055):f2}");
                    }
                    else if (buy > 500 && buy <= 1000)
                    {
                        Console.WriteLine($"{(buy * 0.08):f2}");
                    }
                    else if (buy > 1000 && buy <= 10000)
                    {
                        Console.WriteLine($"{(buy * 0.12):f2}");
                    }
                    else if (buy > 10000)
                    {
                        Console.WriteLine($"{(buy * 0.145):f2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
