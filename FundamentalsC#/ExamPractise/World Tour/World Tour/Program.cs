using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Name
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder destinations = new StringBuilder(input);
            string[] command = Console.ReadLine().Split(':');
            while (command[0] != "Travel")
            {
                switch (command[0])
                {
                    case "Add Stop":
                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= destinations.Length)
                        {
                            Console.WriteLine(destinations);
                            break;
                        }
                        else
                        {
                            destinations.Insert(int.Parse(command[1]), command[2]);
                            Console.WriteLine(destinations);
                        }
                        break;
                    case "Remove Stop":
                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) >= destinations.Length || int.Parse(command[2]) < 0 || int.Parse(command[2]) >= destinations.Length)
                        {
                            Console.WriteLine(destinations);
                            break;
                        }
                        else
                        {
                            destinations.Remove(int.Parse(command[1]), int.Parse(command[2]) - int.Parse(command[1]) + 1);
                            Console.WriteLine(destinations);
                        }
                        break;
                    case "Switch":
                        if (destinations.ToString().Contains(command[1]))
                        {
                            destinations.Replace(command[1], command[2]);

                        }
                        Console.WriteLine(destinations);
                        break;
                }
                command = Console.ReadLine().Split(':');
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}