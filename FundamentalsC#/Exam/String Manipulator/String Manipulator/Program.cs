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
            string messege = Console.ReadLine();
            
            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Translate":
                        StringBuilder sb = new StringBuilder(messege);
                        sb.Replace(command[1], command[2]);
                        messege = sb.ToString();
                        Console.WriteLine(messege);
                        break;
                    case "Includes":
                        bool isIncluded = messege.Contains(command[1]);
                        if (isIncluded)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Start":
                        bool isStarting = false;
                        if (messege.IndexOf(command[1]) == 0)
                        {
                            isStarting = true;
                        }
                        if (isStarting)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Lowercase":
                        messege = messege.ToString().ToLower();
                        Console.WriteLine(messege);
                        break;
                    case "FindIndex":
                        int index = messege.LastIndexOf(command[1]);
                        Console.WriteLine(index);
                        break;
                    case "Remove":
                        messege = messege.Remove(int.Parse(command[1]), int.Parse(command[2]));
                        Console.WriteLine(messege);
                        break;

                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
