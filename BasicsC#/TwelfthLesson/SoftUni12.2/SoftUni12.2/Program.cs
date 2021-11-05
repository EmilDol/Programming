using System;

namespace SoftUni12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            for (int i = num1; i <= num2; i++)
            {
                int rightSum = 0;
                int leftSum = 0;
                string currentNum = i.ToString();
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        rightSum += currentDigit;
                    }
                    else
                    {
                        leftSum += currentDigit;
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
