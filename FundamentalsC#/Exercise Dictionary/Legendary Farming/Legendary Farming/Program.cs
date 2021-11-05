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
                    else if (!junk.ContainsKey(item))
                    {
                        junk.Add(item, quantity);
                    }
                    else
                    {
                        junk[item] += quantity;
                    }

                    if (useful["shards"] >= 250)
                    {
                        isFound = true;
                        Console.WriteLine("Shadowmourne obtained!");
                        useful["shards"] -= 250;
                    }

                    if (useful["fragments"] >= 250)
                    {
                        isFound = true;
                        Console.WriteLine("Valanyr obtained!");
                        useful["fragments"] -= 250;
                    }

                    if (useful["motes"] >= 250)
                    {
                        isFound = true;
                        Console.WriteLine("Dragonwrath obtained!");
                        useful["motes"] -= 250;
                    }

                    if (isFound)
                    {
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
                command = Console.ReadLine().Split().ToArray();
            }

            useful = useful.OrderByDescending(item => item.Value).ToDictionary(item => item.Key, item => item.Value);
            junk = junk.OrderBy(item => item.Key).ToDictionary(item => item.Key, item => item.Value);
            foreach (var VARIABLE in useful)
            {
                Console.WriteLine($"{VARIABLE.Key}: {VARIABLE.Value}");
            }
            foreach (var VARIABLE in junk)
            {
                Console.WriteLine($"{VARIABLE.Key}: {VARIABLE.Value}");
            }
        }
    }
}
