using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Name
{
    class Program
    {
        static void Main()
        {
            Regex barcodePattern = new Regex(@"(?<sep>@#+)(?<word>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+");
            Regex numberPattern = new Regex(@"[0-9]");
            string input;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                if (!barcodePattern.IsMatch(input))
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                MatchCollection numbers = numberPattern.Matches(input);
                if (numbers.Count == 0)
                {
                    Console.WriteLine("Product group: 00");
                }
                else
                {
                    Console.WriteLine($"Product group: {string.Join("", numbers)}");
                }
            }
        }
    }
}
