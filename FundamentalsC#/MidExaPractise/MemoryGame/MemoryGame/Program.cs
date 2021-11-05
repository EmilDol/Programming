using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<string> li = Console.ReadLine().Split().ToList();
            int turns = 0;
            while (true)
            {
                if (li.Count == 0)
                {
                    Console.WriteLine($"You have won in {turns} turns!");
                    return;
                }
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "end")
                {
                    Console.WriteLine($"Sorry you lose :(\n{string.Join(" ", li)}");
                    return;
                }

                if (int.Parse(command[0]) < 0 || int.Parse(command[0]) >= li.Count || int.Parse(command[1]) < 0 || int.Parse(command[1]) >= li.Count || command[0] == command[1])
                {
                    turns++;
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    int insertIndex = li.Count / 2;
                    li.Insert(insertIndex, "-" + turns + "a");
                    li.Insert(insertIndex, "-" + turns + "a");

                    continue;
                }

                if (li[int.Parse(command[0])] == li[int.Parse(command[1])])
                {
                    turns++;
                    Console.WriteLine($"Congrats! You have found matching elements - {li[int.Parse(command[0])]}!");
                    int removeBiggerIndex = int.Parse(command[0]);
                    int removeLowerIndex = int.Parse(command[1]);
                    if (int.Parse(command[0]) < int.Parse(command[1]))
                    {
                        removeBiggerIndex = int.Parse(command[1]);
                        removeLowerIndex = int.Parse(command[0]);
                    }
                    li.RemoveAt(removeBiggerIndex);
                    li.RemoveAt(removeLowerIndex);
                    
                }
                else
                {
                    turns++;
                    Console.WriteLine("Try again!");
                    
                }
            }
        }
    }
}
