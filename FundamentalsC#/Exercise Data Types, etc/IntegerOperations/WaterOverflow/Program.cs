using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int litars = 0;
            int litarsPoaring;
            for (int i = 0; i < lines; i++)
            {
                litarsPoaring = int.Parse(Console.ReadLine());
                if (litars+litarsPoaring> 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                litars += litarsPoaring;
            }
            Console.WriteLine(litars);
        }
    }
}
