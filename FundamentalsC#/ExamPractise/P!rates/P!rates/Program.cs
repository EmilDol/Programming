using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Name
{
    class Target
    {
        public int Gold { get; set; }
        public int Citizens { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Dictionary<string, Target> targets = new Dictionary<string, Target>();
            string[] command = Console.ReadLine().Split("||");
            while (command[0] != "Sail")
            {
                if (targets.ContainsKey(command[0]))
                {
                    targets[command[0]].Gold += int.Parse(command[2]);
                    targets[command[0]].Citizens += int.Parse(command[1]);
                }
                else
                {
                    targets.Add(command[0], new Target());
                    targets[command[0]].Gold = int.Parse(command[2]);
                    targets[command[0]].Citizens = int.Parse(command[1]);
                }
                command = Console.ReadLine().Split("||");
            }
            command = Console.ReadLine().Split("=>");
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Plunder":
                        int killedPpl = int.Parse(command[2]);
                        int stolenGold = int.Parse(command[3]);
                        int previousGold = targets[command[1]].Gold;
                        int previousCity = targets[command[1]].Citizens;
                        targets[command[1]].Gold -= stolenGold;
                        targets[command[1]].Citizens -= killedPpl;

                        bool isUsed = false;
                        if (targets[command[1]].Gold <= 0)
                        {
                            targets[command[1]].Gold = 0;
                            isUsed = true;
                        }
                        if (targets[command[1]].Citizens <= 0)
                        {
                            targets[command[1]].Citizens = 0;
                            isUsed = true;
                        }
                        Console.WriteLine($"{command[1]} plundered! {previousGold - targets[command[1]].Gold} gold stolen, {previousCity - targets[command[1]].Citizens} citizens killed.");
                        if (isUsed)
                        {
                            Console.WriteLine($"{command[1]} has been wiped off the map!");
                            targets.Remove(command[1]);
                        }
                        break;
                    case "Prosper":
                        int gold = int.Parse(command[2]);
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            break;
                        }
                        targets[command[1]].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {command[1]} now has {targets[command[1]].Gold} gold.");
                        break;
                }
                command = Console.ReadLine().Split("=>");
            }
            if (targets.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                targets = targets.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine($"Ahoy, Captain! There are {targets.Count} wealthy settlements to go to:");
                foreach (var item in targets)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Citizens} citizens, Gold: {item.Value.Gold} kg");
                }
            }
        }
    }
}