using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> useful = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            useful.Add("fragments", 0);
            useful.Add("shards", 0);
            useful.Add("motes", 0);
            string[] command = Console.ReadLine().Split().ToArray();
            bool isFound = false;

            while (isFound == false)
            {


                for (int i = 0; i < command.Length; i += 2)
                {
                    int quantity = int.Parse(command[i]);
                    string item = command[i + 1];
                    item = item.ToLower();
                    if (useful.ContainsKey(item))
                    {
                        useful[item] += quantity;
                    }
                    else if (junk.ContainsKey(item))
                    {
                        junk[item] += quantity;
                    }
                    else
                    {
                        junk.Add(item, quantity);
                    }

                    if (useful["shards"] >= 250)
                    {
                        isFound = true;
                        Console.WriteLine("Shadowmourne obtained!");
                        useful["shards"] -= 250;
                        break;
                    }

                    if (useful["fragments"] >= 250)
                    {
                        isFound = true;
                        Console.WriteLine("Valanyr obtained!");
                        useful["fragments"] -= 250;
                        break;
                    }

                    if (useful["motes"] >= 250)
                    {
                        isFound = true;
                        Console.WriteLine("Dragonwrath obtained!");
                        useful["motes"] -= 250;
                        break;
                    }

                    
                }

                if (isFound)
                {
                    break;
                }
                command = Console.ReadLine().Split().ToArray();
            }

            
            foreach (var item in useful.OrderByDescending(key => key.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var Junkitem in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{Junkitem.Key}: {Junkitem.Value}");
            }
            
        }
    }
}
