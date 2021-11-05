using System;

namespace SoftUni8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            Console.WriteLine($"{(p1/n*100):f2}%\n{(p2 / n * 100):f2}%\n{(p3 / n * 100):f2}%\n{(p4 / n * 100):f2}%\n{(p5 / n * 100):f2}%\n");
        }
    }
}
