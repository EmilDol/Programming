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
            string  sb = Console.ReadLine();
            
            string[] cmd = Console.ReadLine().Split(":|:");
            while(cmd[0] != "Reveal")
            {
                switch (cmd[0])
                {
                    case "InsertSpace":
                        sb = sb.Insert(int.Parse(cmd[1]), " ");
                        Console.WriteLine(sb);

                        break;
                    case "Reverse":
                        if (sb.Contains(cmd[1]))
                        {
                            
                            char[] temp = cmd[1].ToCharArray();
                            Array.Reverse(temp);
                            sb = sb.Remove(sb.IndexOf(cmd[1]), cmd[1].Length);
                            string anoutherTemp = string.Join("", temp);
                            sb += anoutherTemp;
                            Console.WriteLine(sb);

                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        int indexOfSubstring = sb.IndexOf(cmd[1]);
                        while (indexOfSubstring >= 0)
                        {
                            sb = sb.Replace(cmd[1], cmd[2]);
                            indexOfSubstring = sb.IndexOf(cmd[1]);
                        }
                        Console.WriteLine(sb);
                        break;
                }
                cmd = Console.ReadLine().Split(":|:");
            }
            Console.WriteLine($"You have a new text message: {sb}");
        }
    }
}