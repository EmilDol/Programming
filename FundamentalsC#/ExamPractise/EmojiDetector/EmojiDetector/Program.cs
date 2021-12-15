using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Numerics;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex emojiPattern = new Regex(@"(?<sep>[:*])\k<sep>(?<word>[A-Z][a-z]{2,})\k<sep>\k<sep>");
            Regex nums = new Regex(@"-?[0-9]");
            string input = Console.ReadLine();
            MatchCollection numbers = nums.Matches(input);
            MatchCollection emojis = emojiPattern.Matches(input);
            int coolness = 1;
            if (numbers.Count == 0)
            {
                coolness = 0;
            }
            foreach (Match item in numbers)
            {
                coolness *= int.Parse(item.Value);
            }
            Console.WriteLine($"Cool threshold: {coolness}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            foreach (Match item in emojis)
            {
                char[] temp = item.Groups["word"].Value.ToCharArray();
                int cool = 0;
                foreach (char c in temp)
                {
                    cool += (int)c;
                }
                if (cool > coolness)
                {
                    Console.WriteLine($"{item.Groups["sep"].Value}{item.Groups["sep"]}{item.Groups["word"].Value}{item.Groups["sep"].Value}{item.Groups["sep"].Value}");
                }
            }
        }
    }
}
