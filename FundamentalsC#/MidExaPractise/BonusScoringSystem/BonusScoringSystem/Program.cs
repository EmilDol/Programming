using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfStudents = double.Parse(Console.ReadLine());
            double numberOfLectures = double.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());
            double bestBonus = 0;
            double bestLectures = 0;
            for (double i = 0; i < numberOfStudents; i++)
            {
                double prisustvie = double.Parse(Console.ReadLine());
                double bonus = prisustvie / numberOfLectures  * (5 + additionalBonus);
                if (bestBonus < bonus)
                {
                    bestBonus = bonus;
                    bestLectures = prisustvie;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(bestBonus)}.\nThe student has attended {bestLectures} lectures.");
        }
    }
}
