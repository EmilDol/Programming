using System;

namespace SoftUni4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (num <= 100)
            {
                bonus += 5;
            }
            if (num > 1000)
            {
                bonus += (num * 0.10);
            }
            else if (num <= 1000 && num > 100)
            {
                bonus += (num * 0.20);
            }
            if (num % 2 == 0)
            {
                bonus += 1;
            }
            else if (num % 5 == 0 && num % 10 != 0)
            {
                bonus += 2;
            }

            Console.WriteLine($"{bonus}\n{num + bonus}");
        }
    }
}
