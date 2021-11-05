using System;

namespace SoftUni10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();
            int counter = 0;
            string input = Console.ReadLine();
            while (input != "No More Books")
            {
                if (input == wantedBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    return;
                }
                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"The book you search is not here!\nYou checked {counter} books.");
        }
    }
}
