using System;

namespace Exam5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sleep = "sad";
            int meters;
            int days = 1;
            int totalMeters = 5364;
            while (true)
            {
                sleep = Console.ReadLine();
                if (sleep == "END")
                {
                    break;
                }
                meters = int.Parse(Console.ReadLine());
                
                
                
                if (sleep == "Yes")
                {
                    days++;
                }
                if (days > 5)
                {
                    break;
                }
                totalMeters += meters;
                if (totalMeters >= 8848)
                {
                    Console.WriteLine($"Goal reached for {days} days!");
                    return;
                }
                
            }
            Console.WriteLine($"Failed!\n{totalMeters}");
        }
    }
}
