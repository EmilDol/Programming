using System;

namespace SoftUni7._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 1; i <= rows; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes\nSum = {oddSum}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}
