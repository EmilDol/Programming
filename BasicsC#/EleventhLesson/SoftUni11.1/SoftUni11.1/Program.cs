using System;

namespace SoftUni11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    Console.WriteLine($"{i}:{j}");
                }
            }
        }
    }
}
