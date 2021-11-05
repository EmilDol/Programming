using System;
using System.Linq;

namespace TheAngryCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int startingIndex = int.Parse(Console.ReadLine());
            string pricing = Console.ReadLine();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < startingIndex; i++)
            {
                if (pricing == "cheap" && items[i] < items[startingIndex])
                {
                    leftSum += items[i];
                }

                if (pricing == "expensive" && items[i] >= items[startingIndex])
                {
                    leftSum += items[i];
                }
            }

            for (int i = startingIndex + 1; i < items.Length; i++)
            {
                if (pricing == "cheap" && items[i] < items[startingIndex])
                {
                    rightSum += items[i];
                }

                if (pricing == "expensive" && items[i] >= items[startingIndex])
                {
                    rightSum += items[i];
                }
            }
            if (rightSum > leftSum)
            {
                Console.WriteLine($"Right - {rightSum}");
                return;
            }

            Console.WriteLine($"Left - {leftSum}");
        }
    }
}
