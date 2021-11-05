using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int KrajbaZaDen = int.Parse(Console.ReadLine());
            double expected = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= days; i++)
            {
                sum += KrajbaZaDen;
                if (i % 3 == 0)
                {

                    sum += (KrajbaZaDen * 0.5);
                }

                if (i % 5 == 0)
                {
                    sum -= (sum * 0.3);
                }


            }

            if (sum >= expected)
            {
                Console.WriteLine($"Ahoy! {sum:f2} plunder gained.");
            }
            else
            {
                double percents = (sum / expected) * 100;
                Console.WriteLine($"Collected only {percents:f2}% of the plunder.");
            }

        }
    }
}
