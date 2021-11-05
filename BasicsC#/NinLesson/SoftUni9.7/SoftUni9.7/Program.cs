using System;

namespace SoftUni9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int max = int.MinValue;
            int num = 0;
            while (true)
            {
                try
                {
                    num = int.Parse(command);
                }
                catch (FormatException)
                {
                    Console.WriteLine(max);
                    return;
                }
                if (max < num)
                {
                    max = num;
                }
                command = Console.ReadLine();
            }
        }
    }
}
