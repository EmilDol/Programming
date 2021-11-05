using System;

namespace SoftUni11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i <= num; i++)
            {
                for (int j = 0; j <= num; j++)
                {
                    for (int l = 0; l <= num; l++)
                    {
                        if (i + j + l == num)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
