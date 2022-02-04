using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackSmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Queue<int> steel = new Queue<int>(input);
            input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Dictionary<string, int> swords = new Dictionary<string, int>();
            Stack<int> carbon = new Stack<int>(input);
            while (carbon.Any() && steel.Any())
            {
                int currSteel = steel.Dequeue();
                int currCarbon = carbon.Pop();
                if (currCarbon + currSteel == 70)
                {
                    if (swords.ContainsKey("Gladius"))
                    {
                        swords["Gladius"]++;
                    }
                    else
                    {
                        swords.Add("Gladius", 1);
                    }
                }
                else if (currSteel + currCarbon == 80)
                {
                    if (swords.ContainsKey("Shamshir"))
                    {
                        swords["Shamshir"]++;
                    }
                    else
                    {
                        swords.Add("Shamshir", 1);
                    }
                }
                else if (currSteel + currCarbon == 90)
                {
                    if (swords.ContainsKey("Katana"))
                    {
                        swords["Katana"]++;
                    }
                    else
                    {
                        swords.Add("Katana", 1);
                    }
                }
                else if (currSteel + currCarbon == 110)
                {
                    if (swords.ContainsKey("Sabre"))
                    {
                        swords["Sabre"]++;
                    }
                    else
                    {
                        swords.Add("Sabre", 1);
                    }
                }
                else if (currSteel + currCarbon == 150)
                {
                    if (swords.ContainsKey("Broadsword"))
                    {
                        swords["Broadsword"]++;
                    }
                    else
                    {
                        swords.Add("Broadsword", 1);
                    }
                }
                else
                {
                    carbon.Push(currCarbon + 5);
                }
            }
            if (!swords.Any())
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            else
            {
                Console.WriteLine($"You have forged {swords.Sum(x => x.Value)} swords.");
            }
            Console.Write("Steel left: ");
            if (steel.Any())
            {
                Console.WriteLine(String.Join(", ",steel));
            }
            else
            {
                Console.WriteLine("none");
            }
            Console.Write("Carbon left: ");
            if (carbon.Any())
            {
                Console.WriteLine(String.Join(", ", carbon));
            }
            else
            {
                Console.WriteLine("none");
            }
            swords = swords.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in swords)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
