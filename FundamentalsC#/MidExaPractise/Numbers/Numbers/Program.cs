using System;

using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double avg = input.Average();
            Array.Sort(input);
            Array.Reverse(input);
            bool isPrinted = false;
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > avg && counter < 5)
                {
                    Console.Write($"{input[i]} ");
                    counter++;
                    isPrinted = true;
                }

                if (counter > 5)
                {
                    break;
                }
            }

            if (isPrinted == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
