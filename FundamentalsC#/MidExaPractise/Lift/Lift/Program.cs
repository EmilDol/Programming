using System;
using System.Linq;

namespace Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfGuys = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < lift.Length; i++)
            {
                for (int j = lift[i]; j < 4; j++)
                {
                    if (countOfGuys == 0)
                    {
                        break;
                    }
                    countOfGuys--;
                    lift[i]++;
                }
            }

            bool areEqual = true;
            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] != 4)
                {
                    areEqual = false;
                }
            }
            if (areEqual == false && countOfGuys == 0)
            {
                Console.WriteLine($"The lift has empty spots!\n{string.Join(" ", lift)}");
            }
            else if (areEqual == true && countOfGuys != 0)
            {
                Console.WriteLine(
                    $"There isn't enough space! {countOfGuys} people in a queue!\n{string.Join(" ", lift)}");
            }
            else if (areEqual == true && countOfGuys == 0)
            {
                Console.WriteLine(string.Join(" ", lift));
            }

            
        }
    }
}
