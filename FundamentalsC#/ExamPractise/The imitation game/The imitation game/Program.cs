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
            string input = Console.ReadLine();
            StringBuilder code = new StringBuilder(input);  
            string[] command = Console.ReadLine().Split('|');
            while (command[0] != "Decode")
            {
                switch (command[0])
                {
                    case "Move":
                        string temp = code.ToString().Substring(0, int.Parse(command[1]));
                        code.Remove(0, int.Parse(command[1]));
                        code.Append(temp);
                        break;
                    case "Insert":
                        code.Insert(int.Parse(command[1]), command[2]);
                        break;
                    case "ChangeAll":
                        code.Replace(command[1], command[2]);
                        break;
                }
                command = Console.ReadLine().Split('|');
            }
            Console.WriteLine($"The decrypted message is: {code}");
        }
    }
}