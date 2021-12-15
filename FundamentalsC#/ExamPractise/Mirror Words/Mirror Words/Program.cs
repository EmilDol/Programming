using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<separator>#|@)(?<word>[A-Za-z]{3,})\k<separator>\k<separator>(?<secondWord>[A-Za-z]{3,})\k<separator>");
            string text = Console.ReadLine();
            MatchCollection matches = regex.Matches(text);
            Dictionary<string, string> mirrored = new Dictionary<string, string>();
            if (matches.Count >= 1)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            foreach (Match match in matches)
            {
                char[] word1 = match.Groups["word"].Value.ToCharArray();
                Array.Reverse(word1);
                char[] word2 = match.Groups["secondWord"].Value.ToCharArray();
                int length = word1.Length;
                if (word1.Length != word2.Length)
                {
                    continue;
                }
                bool mirror = true;
                for (int i = 0; i < length; i++)
                {
                    if (word1[i] != word2[i])
                    {
                        mirror = false;
                    }
                }
                if (mirror)
                {
                    mirrored.Add(match.Groups["word"].Value, match.Groups["secondWord"].Value);
                }
            }

            if (mirrored.Count >= 1)
            {
                Console.WriteLine($"The mirror words are:");
                for (int i = 0; i < mirrored.Count; i++)
                {
                    KeyValuePair<string, string> kvp = mirrored.ElementAt(i);
                    Console.Write($"{kvp.Key} <=> {kvp.Value}");
                    if (i != mirrored.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }

        }
    }
}
