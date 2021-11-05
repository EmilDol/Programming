using System;

namespace SoftUni9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int SUM = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = int.Parse(Console.ReadLine());
            sum += num;
            while (sum < SUM)
            {
                sum += num;
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
