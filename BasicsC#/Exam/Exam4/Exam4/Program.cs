using System;

namespace Exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kilometras = double.Parse(Console.ReadLine());
            double percentPerDay;
            double totalKilometras = kilometras;
            for (int i = 0; i < days; i++)
            {
                
                percentPerDay = double.Parse(Console.ReadLine());
                double adding = percentPerDay / 100 * kilometras;
                kilometras += adding;
                totalKilometras += kilometras;
            }
            if (totalKilometras >= 1000)
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKilometras - 1000)} more kilometers!");
            }
            else
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000 - totalKilometras)} more kilometers");
            }
        }
    }
}
