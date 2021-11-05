using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int countOfKegs = int.Parse(Console.ReadLine());
            string biggestModel = "sad";
            double biggestVolume = 0;
            for (int i = 0; i < countOfKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int heigth = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * heigth;
                if (volume > biggestVolume)
                {
                    biggestModel = model;
                    biggestVolume = volume;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}
