using System;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split("|").ToArray();
            int bitcoin = 0;
            int health = 100;
            
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currRoom = rooms[i].Split();
                switch (currRoom[0])
                {
                    case "potion":
                        int healAmount = 0;
                        for (int j = health; j < 100; j++)
                        {
                            health++;
                            healAmount++;
                            if (healAmount>= int.Parse(currRoom[1]))
                            {
                                break;
                            }
                        }

                        Console.WriteLine($"You healed for {healAmount} hp.\nCurrent health: {health} hp.");
                        break;
                    case "chest":
                        bitcoin += int.Parse(currRoom[1]);
                        Console.WriteLine($"You found {currRoom[1]} bitcoins.");
                        
                        break;
                    default:
                        if (int.Parse(currRoom[1]) >= health)
                        {
                            Console.WriteLine($"You died! Killed by {currRoom[0]}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {currRoom[0]}.");
                            health -= int.Parse(currRoom[1]);
                        }
                        break;
                }
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoin}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
