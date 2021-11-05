using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
             int firstNum = int.Parse(Console.ReadLine());
             int addNum = int.Parse(Console.ReadLine());
             int divideNum = int.Parse(Console.ReadLine());
             int multyNum = int.Parse(Console.ReadLine());

            int final = (firstNum + addNum) / divideNum * multyNum;
            Console.WriteLine(final);
        }   
    }       
}           
