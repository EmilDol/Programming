using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int Originalower = power;
            int exhaoustionFactor = int.Parse(Console.ReadLine());
            int counter = 0;
            while (power >= distance)
            {
                power -= distance;
                counter++;
                if (Originalower * 0.5 == power && exhaoustionFactor > 0)
                {
                    power /= exhaoustionFactor;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(counter);
        }
    }
}
