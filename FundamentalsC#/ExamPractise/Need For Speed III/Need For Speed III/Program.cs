using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] car = Console.ReadLine().Split('|');
                cars.Add(car[0], new List<int>());
                cars[car[0]].Add(int.Parse(car[1]));
                cars[car[0]].Add(int.Parse(car[2]));
            }

            string[] cmd = Console.ReadLine().Split(" : ");
            while (cmd[0] != "Stop")
            {
                switch (cmd[0])
                {
                    case "Drive":
                        if (cars[cmd[1]][1] - int.Parse(cmd[3]) >= 0)
                        {
                            cars[cmd[1]][1] -= int.Parse(cmd[3]);
                            cars[cmd[1]][0] += int.Parse(cmd[2]);
                            Console.WriteLine($"{cmd[1]} driven for {int.Parse(cmd[2])} kilometers. {int.Parse(cmd[3])} liters of fuel consumed.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        if (cars[cmd[1]][0] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {cmd[1]}!");
                            cars.Remove(cmd[1]);
                        }
                        break;
                    case "Refuel":
                        if (cars[cmd[1]][1] + int.Parse(cmd[2]) >= 75)
                        {
                            cars[cmd[1]][1] = 75;
                            Console.WriteLine($"{cmd[1]} refueled with {75 - int.Parse(cmd[2])} liters");
                        }
                        else
                        {
                            cars[cmd[1]][1] += int.Parse(cmd[2]);
                            Console.WriteLine($"{cmd[1]} refueled with {int.Parse(cmd[2])} liters");
                        }

                        break;
                    case "Revert":
                        cars[cmd[1]][0] -= int.Parse(cmd[2]);
                        if (cars[cmd[1]][0] <= 10000)
                        {
                            cars[cmd[1]][0] = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{cmd[1]} mileage decreased by {int.Parse(cmd[2])} kilometers");
                        }
                        break;
                }
                cmd = Console.ReadLine().Split(" : ");
            }
            cars = cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }
        }
    }
}