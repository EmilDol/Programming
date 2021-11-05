using System;

namespace SoftUni3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            const string key = "s3cr3t!P@ssw0rd";
            string password = Console.ReadLine();
            if (password == key)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
