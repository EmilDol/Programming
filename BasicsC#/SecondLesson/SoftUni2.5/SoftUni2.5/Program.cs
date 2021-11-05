using System;

namespace SoftUni2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double zalaCena = double.Parse(Console.ReadLine());
            double tortaCena = zalaCena * 0.2;
            double napitakiCena = tortaCena - tortaCena * 0.45;
            double AnimatorCena = zalaCena / 3;
            Console.WriteLine(zalaCena + tortaCena + napitakiCena + AnimatorCena);
        }
    }
}
