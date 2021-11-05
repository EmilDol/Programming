using System;

namespace softuni2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int higth = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double litar = (length * higth * width) * 0.001;
            Console.WriteLine($"{litar * (1 - (percent * 0.01)):f5}");
        }
    }
}
