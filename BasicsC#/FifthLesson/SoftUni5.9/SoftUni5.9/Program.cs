using System;

namespace SoftUni5._6
{
    class Program
    {
        static void Main(string[] args)
        {

            string st = Console.ReadLine();
            switch (st)
            {
                case "banana":
                case "apple":
                case "cherry":
                case "lemon":
                case "grapes":
                case "kiwi": Console.WriteLine("fruit"); break;
                case "tomato":
                case "cucumber": 
                case "pepper":
                case "carrot": Console.WriteLine("vegetable"); break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
