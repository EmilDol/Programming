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
            string password = Console.ReadLine();
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "Done")
            {
                switch (command[0])
                {
                    case "TakeOdd":
                        string newPass = "";
                        for (int i = 0; i < password.Length; i++)
                        {
                            if (i % 2 != 0)
                            {
                                newPass += password[i];
                            }
                        }
                        password = newPass;
                        Console.WriteLine(password);
                        break;
                    case "Cut":
                        string cut = password.Substring(int.Parse(command[1]), int.Parse(command[2]));
                        password = password.Remove(password.IndexOf(cut), cut.Length);
                        Console.WriteLine(password);

                        break;
                    case "Substitute":
                        if (!password.Contains(command[1]))
                        {
                            Console.WriteLine("Nothing to replace!");
                            break;
                        }
                        else
                        {
                            password = password.Replace(command[1], command[2]);
                            Console.WriteLine(password);

                        }


                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}