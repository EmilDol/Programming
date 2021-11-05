using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;
            while (true)
            {
                if (capacity * courses >= people)
                {
                    Console.WriteLine(courses);
                    return;
                }
                courses++;
            }
        }
    }
}
