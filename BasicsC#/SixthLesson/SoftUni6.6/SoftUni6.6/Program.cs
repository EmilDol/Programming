using System;

namespace SoftUni6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            string evenOrOdd = "odd";

            switch (symbol)
            {
                case "+":
                    if ((num2 + num1) % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    Console.WriteLine($"{num1} + {num2} = {num2 + num1} - {evenOrOdd}");
                    break;
                case "-":
                    if ((num1 - num2) % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2} - {evenOrOdd}");
                    break;
                case "*":
                    if ((num2 * num1) % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2} - {evenOrOdd}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                        break;
                    }
                    Console.WriteLine($"{num1} / {num2} = {(num1 / num2):f2}");
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                        break;
                    }
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
