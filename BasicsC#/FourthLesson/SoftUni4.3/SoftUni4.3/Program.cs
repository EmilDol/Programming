using System;

namespace SoftUni4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double fastAndFurious = double.Parse(Console.ReadLine());
            if (fastAndFurious <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (fastAndFurious > 10 && fastAndFurious <= 50)
            {
                Console.WriteLine("average");
            }
            else if (fastAndFurious > 50 && fastAndFurious <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (fastAndFurious > 150 && fastAndFurious <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (fastAndFurious > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
