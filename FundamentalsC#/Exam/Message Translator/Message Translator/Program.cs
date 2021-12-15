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
            Regex validPattern = new Regex(@"!(?<command>[A-Z][a-z]{2,})!:\[(?<text>[A-Za-z]{8,})\]");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (!validPattern.IsMatch(input))
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }
                Match match = validPattern.Match(input);
                char[] text = match.Groups["text"].Value.ToCharArray();
                List<int> codes = new List<int>();
                for (int j = 0; j < text.Length; j++)
                {
                    codes.Add((int)text[j]);
                }
                Console.WriteLine($"{match.Groups["command"].Value}: {string.Join(" ", codes)}");
            }
        }
    }
}