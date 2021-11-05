using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            double sum = 0;
            double taxes = 0;
            double price = 0;
            while (true)
            {
                command = Console.ReadLine();
                try
                {
                    if (double.Parse(command) < 0)
                    {
                        Console.WriteLine("Invalid price!");
                        continue;
                    }
                    sum += double.Parse(command);
                    taxes += 0.2 * double.Parse(command);
                    
                }
                catch (FormatException)
                {
                    break;
                }
                
            }

            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            price = sum + taxes;
            if (command == "special")
            {
                price -= price * 0.1;
            }

            Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {sum:f2}$\nTaxes: {taxes:f2}$\n-----------\nTotal price: {price:f2}$");
        }
    }
}
