using System;

namespace SoftUni9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numNow = 1;
            while (numNow <= num)
            {
                Console.WriteLine(numNow);
                numNow = numNow * 2 + 1;
            }
        }
    }
}
