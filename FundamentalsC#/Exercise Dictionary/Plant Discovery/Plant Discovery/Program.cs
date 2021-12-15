using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Name
{
    class Plant
    {
        private List<double> rating = new List<double>();

        public double Rarity { get; set; }
        public List<double> Rating { get => rating; set => rating = value; }
    }
    class Program
    {
        static void Main()
        {
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            double n = double.Parse(Console.ReadLine());
            string[] command;
            for (double i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split("<->");
                if (!plants.ContainsKey(command[0]))
                {
                    
                    plants.Add(command[0], new Plant());
                    plants[command[0]].Rarity = double.Parse(command[1]);
                }
                else
                {
                    plants[command[0]].Rarity = double.Parse(command[1]);
                }
            }
            command = Console.ReadLine().Split(": ");
            
            while (command[0]!= "Exhibition")
            {
                switch (command[0])
                {
                    case "Rate":
                        string[] temp = command[1].Split(" - ");
                        plants[temp[0]].Rating.Add(double.Parse(temp[1]));
                        break;
                    case "Update":
                        string[] otherTemp = command[1].Split(" - ");
                        plants[otherTemp[0]].Rarity = double.Parse(otherTemp[1]);
                        break;
                    case "Reset":
                        plants[command[1]].Rating.Clear();
                        plants[command[1]].Rating.Add(0);
                        
                        break;
                }
                command = Console.ReadLine().Split(": ");
            }
            plants = plants.OrderByDescending(x => x.Value.Rarity).ThenByDescending(x => x.Value.Rating.Average()).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants)
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {item.Value.Rating.Average():f2}");
            }
        }
    }
}