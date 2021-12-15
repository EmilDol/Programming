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
            int capacity = int.Parse(Console.ReadLine());
            Dictionary<string, Person> usernames = new Dictionary<string, Person>();
            string[] command = Console.ReadLine().Split('=');

            while (command[0] != "Statistics")
            {
                switch (command[0])
                {
                    case "Add":
                        if (usernames.ContainsKey(command[1]))
                        {
                            break;
                        }
                        usernames.Add(command[1], new Person());
                        usernames[command[1]].Sent = int.Parse(command[2]);
                        usernames[command[1]].Received = int.Parse(command[3]);
                        break;
                    case "Message":
                        if (!usernames.ContainsKey(command[1]) || !usernames.ContainsKey(command[2]))
                        {
                            break;
                        }
                        usernames[command[1]].Sent++;
                        usernames[command[2]].Received++;
                        if (usernames[command[1]].Total >= capacity)
                        {
                            Console.WriteLine($"{command[1]} reached the capacity!");
                            usernames.Remove(command[1]);
                        }
                        if (usernames[command[2]].Total >= capacity)
                        {
                            Console.WriteLine($"{command[2]} reached the capacity!");
                            usernames.Remove(command[2]);
                        }
                        break;
                    case "Empty":
                        if (command[1] == "All")
                        {
                            usernames.Clear();
                            break;
                        }
                        if (!usernames.ContainsKey(command[1]))
                        {
                            break;
                        }
                        usernames.Remove(command[1]);
                        break;
                }
                command = Console.ReadLine().Split('=');
            }
            Console.WriteLine($"Users count: {usernames.Count}");
            usernames = usernames.OrderByDescending(x => x.Value.Received).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in usernames)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Total}");
            }
        }
    }
    class Person
    {
        public int Sent { get; set; }
        public int Received { get; set; }


        public int Total
        {
            get { return Sent + Received; }
        }

    }
}