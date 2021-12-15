using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heights = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int climbMinutes = 0, maxClimbMinutes = climbMinutes;

            for (int index = 1; index < heights.Length; index++)
            {
                if (heights[index - 1] < heights[index])
                {
                    climbMinutes++;
                }
                else
                {
                    if (climbMinutes > maxClimbMinutes)
                    {
                        maxClimbMinutes = climbMinutes;
                    }
                }
            }

            Console.WriteLine(maxClimbMinutes);

        }
    }
}
