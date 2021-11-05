using System;

namespace SoftUni4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string userInput = Console.ReadLine();
            string ExpectedOutput;

            switch (userInput)
            {
                case "m":
                    ExpectedOutput = Console.ReadLine();
                    switch (ExpectedOutput)
                    {
                        case "mm": Console.WriteLine($"{(num * 1000):f3}");  break;
                        case "cm": Console.WriteLine($"{(num * 100):f3}"); break;
                    }
                    break;
                case "mm":
                    ExpectedOutput = Console.ReadLine();
                    switch (ExpectedOutput)
                    {
                        case "m":
                            Console.WriteLine($"{(num / 1000):f3}"); break;
                        case "cm":
                            Console.WriteLine($"{(num / 10):f3}"); break;
                    }
                    break;
                case "cm":
                    ExpectedOutput = Console.ReadLine();
                    switch (ExpectedOutput)
                    {
                        case "m":
                            Console.WriteLine($"{(num / 100):f3}"); break;
                        case "mm":
                            Console.WriteLine($"{(num * 10):f3}"); break;
                    }
                    break;
            }
        }
    }
}
