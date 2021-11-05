using System;

namespace SoftUni13._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int start4 = start % 10;
            start /= 10;
            int start3 = start % 10;
            start /= 10;
            int start2 = start % 10;
            start /= 10;
            int start1 = start % 10;
            
            int finish4 = finish % 10;
            finish /= 10;
            int finish3 = finish % 10;
            finish /= 10;
            int finish2 = finish % 10;
            finish /= 10;
            int finish1 = finish % 10;
            for (int i = start1; i <= finish1; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                for (int j = start2; j <= finish2; j++)
                {
                    if (j % 2 == 0)
                    {
                        continue;
                    }
                    for (int c = start3; c <= finish3; c++)
                    {
                        if (c % 2 == 0)
                        {
                            continue;
                        }
                        for (int d = start4; d <= finish4; d++)
                        {
                            if (d % 2 == 0)
                            {
                                continue;
                            }
                            Console.Write($"{i}{j}{c}{d} ");
                        }
                    }
                }
            }
        }
    }
}
