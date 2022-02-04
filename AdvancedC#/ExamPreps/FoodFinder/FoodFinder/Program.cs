using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace FoodFinder
{
    class Program
    {
        static void Main()
        {
            List<char> pear = new List<char> { 'p', 'e', 'a', 'r' };
            List<char> flour = new List<char> { 'f', 'l', 'o', 'u', 'r' };
            List<char> pork = new List<char> { 'p', 'o', 'r', 'k' };
            List<char> olive = new List<char> { 'o', 'l', 'i', 'v', 'e' };

            List<string> output = new List<string>();

            char[] input = Console.ReadLine().ToCharArray();
            Queue<char> vowels = new Queue<char>(input);
            input = Console.ReadLine().ToCharArray();
            Stack<char> unvowels = new Stack<char>(input);
            while (unvowels.Any())
            {
                char currVowel = vowels.Dequeue();
                vowels.Enqueue(currVowel);
                char currUnvowel = unvowels.Pop();

                if (pear.Contains(currVowel))
                {
                    pear.RemoveAll(x => x == currVowel);
                }
                if (flour.Contains(currVowel))
                {
                    flour.RemoveAll(x => x == currVowel);
                }
                if (pork.Contains(currVowel))
                {
                    pork.RemoveAll(x => x == currVowel);
                }
                if (olive.Contains(currVowel))
                {
                    olive.RemoveAll(x => x == currVowel);
                }
                



                if (flour.Contains(currUnvowel))
                {
                    flour.RemoveAll(x => x == currUnvowel);
                }
                if (pork.Contains(currUnvowel))
                {
                    pork.RemoveAll(x => x == currUnvowel);
                }
                if (olive.Contains(currUnvowel))
                {
                    olive.RemoveAll(x => x == currUnvowel);
                }
                if (pear.Contains(currUnvowel))
                {
                    pear.RemoveAll(x => x == currUnvowel);
                }
                
            }

            int foundWords = 0;

            foundWords += pear.Any() ? 0 : 1;
            foundWords += flour.Any() ? 0 : 1;
            foundWords += pork.Any() ? 0 : 1;
            foundWords += olive.Any() ? 0 : 1;

            output = FindEmptys(pear, flour, pork, olive, output);
            Console.WriteLine($"Words found: {foundWords}");
            Console.WriteLine($"{string.Join("\n",output)}");

        }

        public static List<string> FindEmptys(List<char> pear, List<char> flour, List<char> pork, List<char> olive, List<string> output)
        {
            if (pear.Count == 0 && !output.Contains("pear")) output.Add("pear");
            if (flour.Count == 0 && !output.Contains("flour")) output.Add("flour");
            if (pork.Count == 0 && !output.Contains("pork")) output.Add("pork");
            if (olive.Count == 0 && !output.Contains("olive")) output.Add("olive");
            return output;
        }
    }
}