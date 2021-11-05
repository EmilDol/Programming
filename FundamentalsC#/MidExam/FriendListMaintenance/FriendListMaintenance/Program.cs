using System;
using System.Collections.Generic;
using System.Linq;


namespace FriendListMaintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friendList = Console.ReadLine().Split(", ").ToList();
            int blacklisted = 0;
            int lost = 0;
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Blacklist":
                        if (friendList.Contains(command[1]) == true)
                        {
                            int index = friendList.FindIndex(x => x == command[1]);


                            Console.WriteLine($"{command[1]} was blacklisted.");
                            blacklisted++;
                            friendList[index] = "Blacklisted";
                            break;

                        }

                        Console.WriteLine($"{command[1]} was not found.");
                        break;
                    case "Error":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < friendList.Count)
                        {
                            if (friendList[int.Parse(command[1])] != "Lost" && friendList[int.Parse(command[1])] != "Blacklisted")
                            {
                                Console.WriteLine($"{friendList[int.Parse(command[1])]} was lost due to an error.");
                                lost++;
                                friendList[int.Parse(command[1])] = "Lost";
                            }
                        }
                        break;
                    case "Change":
                        if (int.Parse(command[1]) >= 0 && int.Parse(command[1]) < friendList.Count)
                        {


                            Console.WriteLine($"{friendList[int.Parse(command[1])]} changed his username to {command[2]}.");

                            friendList[int.Parse(command[1])] = command[2];

                        }
                        break;
                    default:
                        Console.WriteLine($"Blacklisted names: {blacklisted}");
                        Console.WriteLine($"Lost names: {lost}");
                        Console.WriteLine(string.Join(" ", friendList));
                        return;
                }

            }
        }
    }
}
