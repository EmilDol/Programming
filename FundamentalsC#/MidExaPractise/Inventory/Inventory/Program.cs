using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" - ").ToArray();
                switch (command[0])
                {
                    case "Collect":
                        if (inventory.Contains(command[1]))
                        {
                            continue;
                        }
                        inventory.Add(command[1]);
                        break;
                    case "Drop":
                        if (inventory.Contains(command[1]) == false)
                        {
                            continue;
                        }
                        inventory.Remove(command[1]);
                        break;
                    case "Renew":
                        if (inventory.Contains(command[1]) == false)
                        {
                            continue;
                        }

                        inventory.Remove(command[1]);
                        inventory.Add(command[1]);
                        break;
                    case "Combine Items":
                        string[] tempItems = command[1].Split(":");

                        if (inventory.Contains(tempItems[0]) == false)
                        {
                            continue;
                        }
                        int index = inventory.FindIndex(x => x == tempItems[0]) + 1;
                        inventory.Insert(index, tempItems[1]);
                        break;
                    case "Craft!":
                        Console.WriteLine(string.Join(", ", inventory));
                        return;
                }

            }

            
        }
    }
}
