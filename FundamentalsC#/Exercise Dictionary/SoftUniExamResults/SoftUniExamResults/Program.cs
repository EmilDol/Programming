using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> grades = new Dictionary<string, Dictionary<string, int>>();
            string[] command = Console.ReadLine().Split("-").ToArray();

            while (true)
            {
                if (command[0] == "exam finished")
                {
                    break;
                }
                string user = command[0];

                if (command[1] == "banned")
                {
                    for (int i = 0; i < grades.Count; i++)
                    {
                        if (grades.ElementAt(i).Value.ContainsKey(user))
                        {
                            if (grades.ElementAt(i).Value.ContainsKey("banned"))
                            {
                                grades.ElementAt(i).Value["banned"]++;
                            }
                            else
                            {
                                grades.ElementAt(i).Value.Add("banned", 1);
                            }

                            grades.ElementAt(i).Value.Remove(user);
                        }
                    }
                    break;
                }


                string path = command[1];
                int score = int.Parse(command[2]);
                if (grades.ContainsKey(path))
                {
                    if (!grades[path].ContainsKey(user))
                    {
                        grades[path].Add(user, score);
                    }
                    else
                    {
                        Dictionary<string, int> temp = grades[path];
                        if (temp[user] < score)
                        {
                            temp[user] = score;
                        }

                        if (!grades[path].ContainsKey("duplicates"))
                        {
                            temp.Add("duplicates", 1);
                        }
                        else
                        {
                            temp["duplicates"]++;
                        }
                        grades[path] = temp;
                    }
                }
                else
                {
                    grades.Add(path, new Dictionary<string, int>() { { user, score } });
                }

                command = Console.ReadLine().Split("-").ToArray();
            }

            Console.WriteLine("Results:");

            Dictionary<string, int> temp1 = new Dictionary<string, int>();
            for (int i = 0; i < grades.Count; i++)
            {
                foreach (var VARIABLE in grades.ElementAt(i).Value)
                {
                    if (VARIABLE.Key == "banned" || VARIABLE.Key == "duplicates")
                    {
                        continue;
                    }

                    temp1.Add(VARIABLE.Key, VARIABLE.Value);
                }
            }

            temp1 = temp1.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var VARIABLE in temp1)
            {
                Console.WriteLine($"{VARIABLE.Key} | {VARIABLE.Value}");
            }

            Console.WriteLine("Submissions:");
            Dictionary<string, int> temp2 = new Dictionary<string, int>();
            foreach (var VARIABLE in grades)
            {
                int submissions = VARIABLE.Value.Count;
                if (VARIABLE.Value.ContainsKey("banned"))
                {
                    submissions += VARIABLE.Value["banned"] - 1;
                }

                if (VARIABLE.Value.ContainsKey("duplicates"))
                {
                    submissions += VARIABLE.Value["duplicates"] - 1;
                }

                temp2.Add(VARIABLE.Key, submissions);
            }

            temp2 = temp2.OrderByDescending(x => x.Value).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var VARIABLE in temp2)
            {
                Console.WriteLine($"{VARIABLE.Key} - {VARIABLE.Value}");
            }
        }
    }
}
