using System;

namespace SoftUni4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PLUS_TIME = 15;
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += PLUS_TIME;
            if (minutes >=60)
            {
                hours ++;
                minutes -= 60;
            }
            if (hours >= 24)
            {
                hours = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
            
        }
    }
}
