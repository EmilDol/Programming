using System;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command;
            int shotTargets = 0;
            while (true)
            {
                command = Console.ReadLine();

                if (command == "End")
                {
                    Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(" ", targets)}");
                    return;
                }
                else if (int.Parse(command) >= targets.Length || int.Parse(command) < 0)
                {
                    continue;
                }
                else if (targets[int.Parse(command)] == -1)
                {
                    continue;
                }
                else
                {
                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] <= targets[int.Parse(command)] && targets[i] != -1 && i != int.Parse(command))
                        {
                            targets[i] += targets[int.Parse(command)];
                        }
                        else if(targets[i] >= targets[int.Parse(command)] && targets[i] != -1 && i != int.Parse(command))
                        {
                            targets[i] -= targets[int.Parse(command)];
                        }
                    }

                    targets[int.Parse(command)] = -1;
                    shotTargets++;
                }
            }
        }
    }
}
