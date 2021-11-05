using System;

namespace SoftUni10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GOAL = 10000;
            int sumOfSteps = 0;
            int steps;
            while (true)
            {
                try
                {
                    steps = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    steps = int.Parse(Console.ReadLine());
                    sumOfSteps += steps;
                    break;
                }
                sumOfSteps += steps;
                if (GOAL <= sumOfSteps)
                {
                    Console.WriteLine($"Goal reached! Good job!\n{sumOfSteps - GOAL} steps over the goal!");
                    return;
                }
            }
            if (GOAL > sumOfSteps)
            {
                Console.WriteLine($"{GOAL - sumOfSteps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine($"Goal reached! Good job!\n{sumOfSteps - GOAL} steps over the goal!");
            }
        }
    }
}
