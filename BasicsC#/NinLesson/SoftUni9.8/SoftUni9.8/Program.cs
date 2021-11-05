using System;

namespace SoftUni9._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double mark;
            double sum = 0;
            for (int i = 0; i < 12; i++)
            {
                mark = double.Parse(Console.ReadLine());
                if (mark == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {i + 1} grade");
                    return;
                }
                sum += mark;
            }
            Console.WriteLine($"{name} graduated. Average grade: {(sum / 12):f2}");
        }
    }
}
