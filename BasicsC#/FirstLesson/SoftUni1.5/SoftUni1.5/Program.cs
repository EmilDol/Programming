using System;

namespace SoftUni1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int dka = int.Parse(Console.ReadLine());
            Console.WriteLine($"The final price is: {(dka * 7.61) - (0.18 * (dka * 7.61))} lv.\nThe discount is: {0.18 * (dka * 7.61)} lv.");
        }
    }
}
