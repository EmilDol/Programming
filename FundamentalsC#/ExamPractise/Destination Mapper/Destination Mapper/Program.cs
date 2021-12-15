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
            Regex destinationPattern = new Regex(@"(?<sep>[=\/])(?<word>[A-Z][A-Za-z]{2,})\k<sep>");
            string input = Console.ReadLine();
            MatchCollection destinations = destinationPattern.Matches(input);
            int travelPoints = 0;
            List<string> output = new List<string>();
            foreach (Match match in destinations)
            {
                travelPoints += match.Groups["word"].Value.Length;
                output.Add(match.Groups["word"].Value);
            }
            Console.WriteLine($"Destinations: {string.Join(", ", output)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
            
        }
    }
}