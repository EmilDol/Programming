using System;

namespace SoftUni8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double rows = double.Parse(Console.ReadLine());
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double oddSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double evenSum = 0;
            for (int i = 1; i <= rows; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (evenMax < num)
                    {
                        evenMax = num;
                    }
                    if (evenMin > num)
                    {
                        evenMin = num;
                    }
                    evenSum += num;
                }
                else
                {
                    if (oddMax < num)
                    {
                        oddMax = num;
                    }
                    if (oddMin > num)
                    {
                        oddMin = num;
                    }
                    oddSum += num;
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin == double.MaxValue && oddMax == double.MinValue)
            {
                Console.WriteLine("OddMin=No,\nOddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},\nOddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin == double.MaxValue && evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMin=No,\nEvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},\nEvenMax={evenMax:f2}");
            }
        }
    }
}
