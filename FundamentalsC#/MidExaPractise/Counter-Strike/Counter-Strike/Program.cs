using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wonBattles = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End of battle")
                {
                    Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
                    return;
                }
                else
                {

                    if (energy >= int.Parse(command))
                    {
                        energy -= int.Parse(command);
                        wonBattles++;
                    }
                    else if (energy < int.Parse(command))
                    {
                        
                        Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                        return;
                    }

                    if (wonBattles % 3 == 0)
                    {
                        energy += wonBattles;
                    }
                }
            }
        }
    }
}
