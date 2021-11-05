using System;

namespace SoftUni6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());
            int acceptableMinutes = minutesExam - 30;
            int acceptableHour = hourExam;
            if (acceptableMinutes < 0)
            {
                acceptableHour = hourExam - 1;
                acceptableMinutes = 60 - Math.Abs(acceptableMinutes);
            }
            if (hourArrival >= acceptableHour && hourArrival <= hourExam)
            {
                if (acceptableMinutes > minutesExam)
                {
                    if ((minutesArrival >= acceptableMinutes && minutesArrival < 60) || (acceptableMinutes >= 0 && acceptableMinutes <= minutesExam))                
                    {
                        Console.WriteLine("On time");
                    }
                    else if (minutesArrival < acceptableMinutes)
                    {
                        Console.WriteLine("Early");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                    }
                }
            }
            else if (hourArrival > hourExam)
            {
                Console.WriteLine("Late");
            }
            else
            {
                Console.WriteLine("Early");
            }
        }
    }
}
