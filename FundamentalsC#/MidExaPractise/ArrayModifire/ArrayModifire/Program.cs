using System;
using System.Linq;

namespace ArrayModifire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split().ToArray();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "swap":
                        int temp = arr[int.Parse(command[1])];
                        arr[int.Parse(command[1])] = arr[int.Parse(command[2])];
                        arr[int.Parse(command[2])] = temp;
                        break;
                    case "multiply":
                        arr[int.Parse(command[1])] *= arr[int.Parse(command[2])];
                        break;
                    case "decrease":
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i]--;
                        }
                        break;
                }

                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}