using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    arr = ExchangeArray(arr, int.Parse(command[1]));
                }
                else if ((command[0] == "min" || command[0] == "max") && command[1] == "odd")
                {
                    MinMaxOdd(arr, command[0]);
                }
                else if ((command[0] == "min" || command[0] == "max") && command[1] == "even")
                {
                    MinMaxEven(arr, command[0]);
                }
                else if (command[0] == "first" || command[0] == "last")
                {
                    NumberFinder(command[0], int.Parse(command[1]), command[2], arr.ToList<int>());
                }
                
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }
        static int[] ExchangeArray(int[] currArray, int splitIndex)
        {

            int[] arr = new int[currArray.Length];
            int index = 0;
            if (splitIndex >= currArray.Length || splitIndex < 0)
            {
                Console.WriteLine("Invalid index");
                return currArray;
            }
            for (int i = splitIndex + 1; i < arr.Length; i++)
            {
                arr[index] = currArray[i];
                index++;
            }
            for (int i = 0; i <= splitIndex; i++)
            {
                arr[index] = currArray[i];
                index++;
            }
            return arr;
        }
        static void MinMaxOdd(int[] arr, string minOrMax)
        {
            
            int min = int.MaxValue;
            int max = int.MinValue;
            int minIndex = -1;
            int maxIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1 && min >= arr[i])
                {
                    minIndex = i;
                    min = arr[i];
                }
                if (arr[i] % 2 == 1 && max <= arr[i])
                {
                    maxIndex = i;
                    max = arr[i];
                }
            }
            if (minOrMax == "min" && minIndex != -1)
            {
                Console.WriteLine(minIndex);
            }
            else if (minOrMax == "max" && maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void MinMaxEven(int[] arr, string minOrMax)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int minIndex = -1;
            int maxIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && min >= arr[i])
                {
                    minIndex = i;
                    min = arr[i];
                }
                if (arr[i] % 2 == 0 && max <= arr[i])
                {
                    maxIndex = i;
                    max = arr[i];
                }
            }
            if (minOrMax == "min" && minIndex != -1)
            {
                Console.WriteLine(minIndex);
            }
            else if (minOrMax == "max" && maxIndex != -1)
            {
                Console.WriteLine(maxIndex);
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }
        static void NumberFinder(string firstOrLast, int count, string evenOrOdd, List<int> arr)
        {


            if (count > arr.Count || count < 0)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            if (firstOrLast == "last")
            {
                arr.Reverse();

            }
            List<int> result = new List<int>();
            int counter = 0;
            int evenOddResult = 0;
            if (evenOrOdd == "odd")
            {
                evenOddResult = 1;
            }
            for (int i = 0; i < arr.Count; i++)
            {
                if (counter >= count)
                {
                    break;
                }
                if (arr[i] % 2 == evenOddResult)
                {
                    result.Add(arr[i]);
                    counter++;
                }

            }
            if (firstOrLast == "last")
            {
                result.Reverse();
            }
            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}

