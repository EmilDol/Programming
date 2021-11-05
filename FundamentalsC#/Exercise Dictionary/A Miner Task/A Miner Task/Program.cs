using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string item = Console.ReadLine();
            int quantiti;
            while (item != "stop")
            {
                quantiti = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(item))
                {
                    resources.Add(item, quantiti);
                }
                else
                {
                    resources[item] += quantiti;
                }
                item = Console.ReadLine();
            }

            foreach (var pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
