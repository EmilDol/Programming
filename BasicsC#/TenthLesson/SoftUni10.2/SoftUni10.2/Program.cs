using System;

namespace SoftUni10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededPoorMarks = int.Parse(Console.ReadLine());
            string nameOfProblem;
            double mark;
            double sum = 0;
            string nameOfLastProblem = "sad";
            int counter = 0;
            int poorMarks = 0;
            while (true)
            {
                nameOfProblem = Console.ReadLine();
                if (nameOfProblem == "Enough")
                {
                    Console.WriteLine($"Average score: {(sum / counter):f2}\n Number of problems: {counter}\n Last problem: {nameOfLastProblem}");
                    return;
                }
                mark = int.Parse(Console.ReadLine());
                if (mark <= 4)
                {
                    poorMarks++;
                }
                if (poorMarks >= neededPoorMarks)
                {
                    Console.WriteLine($"You need a break, {poorMarks} poor grades.");
                    return;
                }
                sum += mark;
                counter++;
                nameOfLastProblem = nameOfProblem;
            }
        }
    }
}
