using System;

namespace ArrayModifire
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstGuy = int.Parse(Console.ReadLine());
            int secondGuy = int.Parse(Console.ReadLine());
            int thirdGuy = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int studentsPerHour = firstGuy + secondGuy + thirdGuy;
            int handled = 0;
            int breakCounter = 0;
            int hours = 0;
            while (handled < students)
            {
                if (breakCounter == 3)
                {
                    hours++;
                    breakCounter = 0;
                    continue;
                }
                handled += studentsPerHour;
                hours++;
                breakCounter++;
            }


            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}