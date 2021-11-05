using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("!").ToList();
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                switch (command[0])
                {
                    case "Urgent":
                        if (list.Contains(command[1]) == true)
                        {
                            continue;
                        }
                        list.Insert(0, command[1]);
                        break;
                    case "Unnecessary":
                        if (list.Contains(command[1]) == false)
                        {
                            continue;
                        }

                        list.Remove(command[1]);
                        break;
                    case "Correct":
                        if (list.Contains(command[1]) == false)
                        {
                            continue;
                        }

                        int index = list.FindIndex(x => x == command[1]);
                        list[index] = command[2];
                        break;
                    case "Rearrange":
                        if (list.Contains(command[1]) == false)
                        {
                            continue;
                        }

                        list.Remove(command[1]);
                        list.Add(command[1]);
                        break;
                    default:
                        Console.WriteLine(string.Join(", ", list));
                        return;
                }
            }
        }
    }
}
