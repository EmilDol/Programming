using System;
using System.Linq;

namespace Man_O_War
{
    class Program
    {
        static void Main()
        {
            int[] pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToArray();
            int[] enemyShip = Console.ReadLine().Split(">").Select(int.Parse).ToArray();
            int maxHealth = int.Parse(Console.ReadLine());
            string[] command;
            while (true)
            {
                command = Console.ReadLine().Split().ToArray();
                switch (command[0])
                {
                    case "Fire":
                        if (int.Parse(command[1]) >= enemyShip.Length || int.Parse(command[1]) < 0)
                        {
                            continue;
                        }
                        if (0 <= int.Parse(command[1]) && int.Parse(command[1]) < enemyShip.Length)
                        {
                            enemyShip[int.Parse(command[1])] -= int.Parse(command[2]);
                            if (enemyShip[int.Parse(command[1])] <= 0)
                            {
                                Console.WriteLine($"You won! The enemy ship has sunken.");
                                return;
                            }
                        }
                        break;
                    case "Defend":
                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= pirateShip.Length || int.Parse(command[2]) < 0 || int.Parse(command[2]) >= pirateShip.Length)
                        {
                            continue;
                        }

                        if (int.Parse(command[1]) >= 0 || int.Parse(command[1]) < pirateShip.Length || int.Parse(command[2]) >= 0 || int.Parse(command[2]) < pirateShip.Length)
                        {
                            int bigger = int.Parse(command[1]);
                            int smaller = int.Parse(command[2]);
                            if (bigger < smaller)
                            {
                                bigger = int.Parse(command[2]);
                                smaller = int.Parse(command[1]);
                            }
                            for (int i = int.Parse(command[1]); i <= int.Parse(command[2]); i++)
                            {
                                pirateShip[i] -= int.Parse(command[3]);
                                if (pirateShip[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    return;
                                }
                            }
                        }

                        break;
                    case "Repair":
                        if (int.Parse(command[1]) >= pirateShip.Length || int.Parse(command[1]) < 0)
                        {
                            continue;
                        }

                        
                        pirateShip[int.Parse(command[1])] += int.Parse(command[2]);
                        if (pirateShip[int.Parse(command[1])] > maxHealth)
                        {
                            pirateShip[int.Parse(command[1])] = maxHealth;
                        }
                        break;
                    case "Status":
                        int needRepair = 0;
                        for (int i = 0; i < pirateShip.Length; i++)
                        {
                            if (pirateShip[i] < (double)maxHealth * 0.2)
                            {
                                needRepair++;
                            }
                        }
                        Console.WriteLine($"{needRepair} sections need repair.");
                        break;
                    case "Retire":
                        Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                        Console.WriteLine($"Warship status: {enemyShip.Sum()}");
                        return;
                }
            }
        }
    }
}
