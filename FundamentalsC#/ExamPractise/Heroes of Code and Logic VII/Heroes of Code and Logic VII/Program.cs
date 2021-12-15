using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Name
{
    class Hero
    {
        public int MP { get; set; }
        public int HP { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            int n = int.Parse(Console.ReadLine());
            string[] command;
            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split();
                heroes.Add(command[0], new Hero());
                heroes[command[0]].HP = int.Parse(command[1]);
                heroes[command[0]].MP = int.Parse(command[2]);
            }
            command = Console.ReadLine().Split(" - ");
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "CastSpell":
                        if (heroes[command[1]].MP >= int.Parse(command[2]))
                        {
                            heroes[command[1]].MP -= int.Parse(command[2]);
                            Console.WriteLine($"{command[1]} has successfully cast {command[3]} and now has {heroes[command[1]].MP} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} does not have enough MP to cast {command[3]}!");
                        }
                        break;
                    case "TakeDamage":
                        heroes[command[1]].HP -= int.Parse(command[2]);
                        if (heroes[command[1]].HP <= 0)
                        {
                            Console.WriteLine($"{command[1]} has been killed by {command[3]}!");
                            heroes.Remove(command[1]);
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} was hit for {command[2]} HP by {command[3]} and now has {heroes[command[1]].HP} HP left!");
                        }
                        break;
                    case "Recharge":
                        int oldMP = heroes[command[1]].MP;
                        heroes[command[1]].MP += int.Parse(command[2]);
                        if (heroes[command[1]].MP > 200)
                        {
                            heroes[command[1]].MP = 200;
                            Console.WriteLine($"{command[1]} recharged for {200 - oldMP} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} recharged for {command[2]} MP!");
                        }
                        break;
                    case "Heal":
                        int oldHP = heroes[command[1]].HP;
                        heroes[command[1]].HP += int.Parse(command[2]);
                        if (heroes[command[1]].HP > 100)
                        {
                            heroes[command[1]].HP = 100;
                            Console.WriteLine($"{command[1]} healed for {100 - oldHP} HP!");
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} healed for {command[2]} HP!");
                        }
                        break;
                }
                command = Console.ReadLine().Split(" - ");
            }
            heroes = heroes.OrderByDescending(x => x.Value.HP).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in heroes)
            {
                Console.WriteLine($"{item.Key}\n  HP: {item.Value.HP}\n  MP: {item.Value.MP}");
            }
        }
    }
}