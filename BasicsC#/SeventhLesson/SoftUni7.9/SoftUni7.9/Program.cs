using System;

namespace SoftUni7._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int rightSum = 0;
            int leftSum = 0;
            for (int i = 0; i < rows; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum += num;
            }
            for (int i = 0; i < rows; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }
        }
    }
}
