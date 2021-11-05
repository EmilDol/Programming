using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command;
            while (true)
            {
                command = Console.ReadLine().Split().ToArray();
                switch (command[0])
                {
                    case "Shoot":
                        if (int.Parse(command[1]) >= targets.Count || int.Parse(command[1]) < 0)
                        {
                            continue;
                        }
                        targets[int.Parse(command[1])] -= int.Parse(command[2]);
                        if (targets[int.Parse(command[1])] <= 0)
                        {
                            targets.RemoveAt(int.Parse(command[1]));
                        }
                        break;
                    case "Add":
                        if (int.Parse(command[1]) >= targets.Count || int.Parse(command[1]) < 0)
                        {
                            Console.WriteLine($"Invalid placement!");
                            continue;
                        }
                        targets.Insert(int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Strike":
                        int removalRange = 2 * int.Parse(command[2]) + 1;
                        if (removalRange > targets.Count)
                        {
                            Console.WriteLine($"Strike missed!");
                            continue;
                        }

                        if (int.Parse(command[1]) - int.Parse(command[2]) < 0 || int.Parse(command[1]) + int.Parse(command[2]) > targets.Count)
                        {
                            Console.WriteLine($"Strike missed!");
                            continue;
                        }
                        int index = int.Parse(command[1]) - int.Parse(command[2]);
                        int counter = 0;
                        while (true)
                        {
                            if (counter >= removalRange)
                            {
                                break;
                            }
                            targets.RemoveAt(index);
                            counter++;
                        }
                        break;
                    case "End":
                        Console.WriteLine(string.Join("|", targets));
                        return;
                }
            }
        }
    }
}
