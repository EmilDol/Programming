using System;

namespace SoftUni3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string figura = Console.ReadLine();
            switch (figura)
            {
                case "square":
                    double strana = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{(strana * strana):f3}");
                    break;
                case "rectangle":
                    double firstStrana = double.Parse(Console.ReadLine());
                    double SecondStrana = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{(firstStrana * SecondStrana):f3}");
                    break;
                case "circle":
                    double Radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{(Radius * Radius * Math.PI):f3}");
                    break;
                case "triangle":
                    double triagalnikStrana = double.Parse(Console.ReadLine());
                    double visochina = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{((triagalnikStrana * visochina)/2):f3}");
                    break;
            }
        }
    }
}
