using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger snowballs = BigInteger.Parse(Console.ReadLine());
            BigInteger snowballSnow = 0;
            BigInteger snowballTime = 0;
            int snowballQuality = 0;
            BigInteger snowballValue = 0;
            BigInteger highestValue = 0;
            string bestFormula = "sad";
            for (BigInteger i = 0; i < snowballs; i++)
            {
                snowballSnow = BigInteger.Parse(Console.ReadLine());
                snowballTime = BigInteger.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                BigInteger value = snowballSnow / snowballTime;
                snowballValue = BigInteger.Pow(value, snowballQuality);
                if (highestValue < snowballValue)
                {
                    highestValue = snowballValue;
                    bestFormula = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }
            Console.WriteLine(bestFormula);
        }
    }
}
