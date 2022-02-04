using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _01.Birthday_Celebration
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> guests = new Queue<int>(input);
            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> plates = new Stack<int>(input);
            int wastedFood = 0;
            int currGuest = 0;
            while (guests.Any() && plates.Any())
            {
                
            }
        }
    }
}