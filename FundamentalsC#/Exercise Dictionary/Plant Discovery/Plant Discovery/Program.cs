class Program
{
    static void Main()
    {
        Dictionary<string, List<int>> plants = new Dictionary<string, List<int>>();
        int n = int.Parse(Console.ReadLine());
        string[] command = Console.ReadLine().Split("<->").ToArray();
        for (int i = 0; i < n; i++)
        {
            if (!plants.ContainsKey(command[0]))
            {
                plants.Add(command[0], new List<int>() { int.Parse(command[1]) });
            }
            else
            {
                plants[command[0]][0] = int.Parse(command[1]);
            }
            command = Console.ReadLine().Split("<->").ToArray();
        }

        while (true)
        {
            command = Console.ReadLine().Split().ToArray();
            switch (command[0])
            {
                case "Rate:":
                    if (!plants.ContainsKey(command[1]))
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    plants[command[1]].Add(int.Parse(command[3]));
                    break;
                case "Update:":
                    if (!plants.ContainsKey(command[1]))
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    plants[command[1]][0] = int.Parse(command[3]);
                    break;
                case "Reset:":
                    int rarity = plants[command[1]][0];
                    plants[command[1]].Clear();
                    plants[command[1]].Add(rarity);
                    break;
                default:
                    Console.WriteLine("Plants for the exhibition:");
                    plants = plants.OrderByDescending(x => x.Value);
                    for (int i = 0; i < plants.Count; i++)
                    {
                        double avg = plants.ElementAt(i).Value.Sum() - plants.ElementAt(i).Value[0];
                        avg /= plants.ElementAt(i).Value.Count - 1;
                        Console.WriteLine($"- {plants.ElementAt(i).Key}; Rarity: {plants.ElementAt(i).Value[0]}; Rating: {avg:f2}");
                    }

                    return;
            }
        }
    }
}
