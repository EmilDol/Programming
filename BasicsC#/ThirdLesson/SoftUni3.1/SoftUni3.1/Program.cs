using System;

namespace SoftUni3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ocenka = double.Parse(Console.ReadLine());
            if (ocenka <= 6 && ocenka >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
