using System;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int last = 0;
            int sum = 0;
            while (num > 0)
            {
                last = num % 10;
                num /= 10;
                sum += last;
            }
            Console.WriteLine(sum);
        }
    }
}
