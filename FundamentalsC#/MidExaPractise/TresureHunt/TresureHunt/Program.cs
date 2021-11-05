using System;
using System.Collections.Generic;
using System.Linq;

namespace TresureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|").ToList();
            string[] command;
            double sum = 0;
            while (true)
            {
                command = Console.ReadLine().Split().ToArray();
                switch (command[0])
                {
                    case "Loot":
                        for (int i = 1; i < command.Length; i++)
                        {
                            if (chest.Contains(command[i]) == true)
                            {
                                continue;
                            }
                            chest.Insert(0, command[i]);
                        }
                        break;
                    case "Drop":

                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= chest.Count)
                        {
                            continue;
                        }
                        string value = chest[int.Parse(command[1])];
                        chest.RemoveAt(int.Parse(command[1]));
                        chest.Add(value);
                        break;
                    case "Steal":
                        List<string> stolenItems = new List<string>();
                        string[] stolenItems2 = new string[chest.Count];
                        if (int.Parse(command[1]) >= chest.Count)
                        {
                            chest.CopyTo(stolenItems2);
                            
                            chest.Clear();
                            Console.WriteLine(string.Join(", ", stolenItems2));

                            Console.WriteLine("Failed treasure hunt.");
                            return;
                        }
                        else
                        {
                            int index = chest.Count - 1;
                            for (int i = 0; i < int.Parse(command[1]); i++)
                            {
                                stolenItems.Add(chest[index]);
                                chest.RemoveAt(index);
                                index--;

                            }

                            stolenItems.Reverse();
                            Console.WriteLine(string.Join(", ", stolenItems));
                        }
                        
                        break;
                    default:
                        sum = 0;
                        foreach (string t in chest)
                        {
                            sum += t.Length;
                        }

                        Console.WriteLine($"Average treasure gain: {(sum/chest.Count):f2} pirate credits.");
                        return;
                }
            }
        }
    }
}
