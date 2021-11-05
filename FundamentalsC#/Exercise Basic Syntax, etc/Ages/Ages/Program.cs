using System;

namespace nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string result = num >= 0 && num <= 2? "baby" : num >= 3 && num <= 13? "child"
                : num >= 14 && num <= 19 ? "teenager" : num >= 20 && num <= 65 ? "adult"
                : num >= 66 ? "elder" : "Not divisible";
            Console.WriteLine(result);
        }
    }
}
