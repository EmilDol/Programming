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
            int key = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"@(?<name>[A-Za-z]+)[^@\-!:>]+!(?<behaviour>[GN])!");
            string input = Console.ReadLine();
            Match names;
            List<string> gudGuys = new List<string>();
            while (input != "end")
            {
                char[] temp = input.ToCharArray();
                char[] decryptedTemp = new char[temp.Length];
                for (int i = 0; i < temp.Length; i++)
                {
                    int code = (int)temp[i];
                    decryptedTemp[i] = (char)(code - key);
                }
                string decryptedMessege = string.Join("", decryptedTemp);
                names = regex.Match(decryptedMessege);
                
                if (names.Groups["behaviour"].Value == "G")
                {
                    gudGuys.Add(names.Groups["name"].Value);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("\n", gudGuys));
        }
    }
}