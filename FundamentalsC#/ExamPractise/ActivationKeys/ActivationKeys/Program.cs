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
            string input = Console.ReadLine();
            StringBuilder key = new StringBuilder(input);
            string[] command  = Console.ReadLine().Split(">>>");
            while (command[0] != "Generate")
            {
                switch (command[0])
                {
                    case "Contains":
                        if (key.ToString().Contains(command[1]))
                        {
                            Console.WriteLine($"{key} contains {command[1]}");
                        }
                        else if (key.ToString().Contains(command[1]) == false)
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        
                        break;
                    case "Flip":
                        string temp = key.ToString().Substring(int.Parse(command[2]), int.Parse(command[3]) - int.Parse(command[2]));
                        string otherTemp = temp;
                        if (command[1] == "Upper")
                        {
                            temp = temp.ToUpper();
                        }
                        else
                        {
                            temp = temp.ToLower();
                        }
                        key.Replace(otherTemp, temp);
                        Console.WriteLine(key);
                        break;
                    case "Slice":
                        key.Remove(int.Parse(command[1]), int.Parse(command[2]) - int.Parse(command[1]));
                        Console.WriteLine(key);
                        break;
                }
                command = Console.ReadLine().Split(">>>");
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}