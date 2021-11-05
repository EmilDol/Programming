using System;

namespace SoftUni10._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int input = 0;
            
            int COUNT_OF_POSSIBLE_PIECES = length * width;
            while (true)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine($"{COUNT_OF_POSSIBLE_PIECES} pieces are left.");
                    return;
                }
                COUNT_OF_POSSIBLE_PIECES -= input;
                if (COUNT_OF_POSSIBLE_PIECES <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(COUNT_OF_POSSIBLE_PIECES)} pieces more.");
                    return;
                }
                
            }
        }
    }
}
