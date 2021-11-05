using System;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighbours = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            int cupidsPosition = 0;
            string[] command;
            int failedPlaces = 0;
            bool isFail = false;
            while (true)
            {
                command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Jump")
                {
                    cupidsPosition += int.Parse(command[1]);
                    if (cupidsPosition >= neighbours.Length)
                    {
                        cupidsPosition = 0;
                    }


                    if (neighbours[cupidsPosition] != 0)
                    {
                        neighbours[cupidsPosition] -= 2;
                        if (neighbours[cupidsPosition] <= 0)
                        {
                            neighbours[cupidsPosition] = 0;
                            Console.WriteLine($"Place {cupidsPosition} has Valentine's day.");
                            continue;
                        }
                    }

                    if (neighbours[cupidsPosition] == 0)
                    {
                        neighbours[cupidsPosition] = 0;
                        Console.WriteLine($"Place {cupidsPosition} already had Valentine's day.");

                    }
                }
                if (command[0] == "Love!")
                {
                    for (int i = 0; i < neighbours.Length; i++)
                    {
                        if (neighbours[i] != 0)
                        {
                            failedPlaces++;
                            isFail = true;
                        }
                    }

                    Console.WriteLine($"Cupid's last position was {cupidsPosition}.");
                    if (isFail)
                    {
                        Console.WriteLine($"Cupid has failed {failedPlaces} places.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Mission was successful.");
                        return;
                    }
                }
            }
        }
    }
}
