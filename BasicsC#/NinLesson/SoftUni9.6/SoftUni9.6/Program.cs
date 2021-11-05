using System;

namespace SoftUni9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int min = int.MaxValue;
            int num = 0;
            while (true)
            {
                try
                {
                    num = int.Parse(command);
                }
                catch (FormatException)
                {
                    Console.WriteLine(min);
                    return;
                }
                if (min > num)
                {
                    min = num;
                }
                command = Console.ReadLine();
            }
        }
    }
}
