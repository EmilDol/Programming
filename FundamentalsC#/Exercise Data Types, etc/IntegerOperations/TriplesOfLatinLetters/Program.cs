using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 97; i < n + 97; i++)
            {
                for (int j = 97; j < n + 97; j++)
                {
                    for (int g = 97; g < n + 97; g++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)g}");
                    }
                }
            }
        }
    }
}
