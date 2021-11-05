using System;

namespace Exam6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int lastDigitOfNum = num % 10;
            bool devidedBy3 = false;
            if (num % 3 == 0)
            {
                devidedBy3 = true;
            }
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 9; b >= a; b--)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 9; d >= c; d--)
                        {
                            if (a * b * c * d == a + b + c + d && lastDigitOfNum == 5)
                            {
                                Console.WriteLine($"{a}{b}{c}{d}");
                                return;
                            }
                            else if ((a*b*c*d)/(a+b+c+d) == 3 && devidedBy3 == true)
                            {
                                Console.WriteLine($"{d}{c}{b}{a}");
                                return;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Nothing found");
        }
    }
}
