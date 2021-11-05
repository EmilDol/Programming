using System;

namespace SoftUni13._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double pointsOfAcademy = double.Parse(Console.ReadLine());
            int countOfJudges = int.Parse(Console.ReadLine());
            string nameOfJudge;
            double pointsOfJudge;
            double totalPoints = pointsOfAcademy;
            for (int i = 0; i < countOfJudges; i++)
            {
                nameOfJudge = Console.ReadLine();
                pointsOfJudge = double.Parse(Console.ReadLine());
                
                totalPoints += (nameOfJudge.Length * pointsOfJudge) / 2;
                if (totalPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {totalPoints:f1}!");
                    return;
                }
            }
            Console.WriteLine($"Sorry, {nameOfActor} you need {(1250.5 - totalPoints):f1} more!");
        }
    }
}
