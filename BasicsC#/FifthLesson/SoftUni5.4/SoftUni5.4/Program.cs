using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int age = int.Parse(Console.ReadLine());
string pol = Console.ReadLine();
            switch (pol)
            {
                case "f":
                    if (age >= 16)
                    {
                        Console.WriteLine("Ms.");
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                    }
                    ; break;
                
                case "m":
                    if (age >= 16)
                    {
                        Console.WriteLine("Mr.");
                    }
                    else
                    {
                        Console.WriteLine("Master");
                    }
                    ; break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
