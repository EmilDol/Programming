using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Armory
{
    class Coordnates
    {
        public int Row { get; set; }
        public int Col { get; set; }
    }
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] armory = new char[n, n];
            Coordnates guy = new Coordnates();
            Coordnates mirror1 = new Coordnates();
            Coordnates mirror2 = new Coordnates();
            bool mirror = false;
            for (int i = 0; i < n; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    armory[i, j] = input[j];
                    if (input[j] == 'A')
                    {
                        guy.Row = i;
                        guy.Col = j;
                    }
                    if (input[j] == 'M' && !mirror)
                    {
                        mirror1.Row = i;
                        mirror1.Col = j;
                        mirror = true;
                    }
                    if (input[j] == 'M' && mirror)
                    {
                        mirror2.Row = i;
                        mirror2.Col = j;
                    }
                }
            }

            int sumSwords = 0;
            string inputDirections = Console.ReadLine();
            while (true)
            {

                switch (inputDirections)
                {
                    case "up":
                        guy.Row--;
                        if (guy.Row >= n || guy.Row < 0)
                        {
                            Console.WriteLine("I do not need more swords!");
                            Console.WriteLine($"The king paid {sumSwords} gold coins.");
                            armory[guy.Row + 1, guy.Col] = '-';
                            PrintMatrix(armory);
                            return;
                        }
                        if (armory[guy.Row, guy.Col] == '-')
                        {
                            armory[guy.Row, guy.Col] = 'A';
                            armory[guy.Row + 1, guy.Col] = '-';
                        }
                        if ((int)armory[guy.Row, guy.Col] >= 49 && (int)armory[guy.Row, guy.Col] <= 57)
                        {
                            sumSwords += int.Parse(armory[guy.Row, guy.Col].ToString());
                            armory[guy.Row + 1, guy.Col] = '-';
                            armory[guy.Row, guy.Col] = 'A';
                        }
                        if (sumSwords >= 65)
                        {
                            Console.WriteLine("Very nice swords, I will come back for more!");
                            Console.WriteLine($"The king paid {sumSwords} gold coins.");
                            PrintMatrix(armory);
                            return;
                        }
                        if (armory[guy.Row, guy.Col] == 'M')
                        {
                            if (guy.Row == mirror1.Row && guy.Col == mirror1.Col)
                            {
                                guy.Row = mirror2.Row;
                                guy.Col = mirror2.Col;
                                armory[mirror1.Row, mirror1.Col] = '-';
                                armory[mirror1.Row + 1, mirror1.Col] = '-';
                                armory[guy.Row, guy.Col] = 'A';
                            }
                            else
                            {
                                guy.Row = mirror1.Row;
                                guy.Col = mirror1.Col;
                                armory[mirror2.Row, mirror2.Col] = '-';
                                armory[mirror2.Row + 1, mirror2.Col] = '-';
                                armory[guy.Row, guy.Col] = 'A';
                            }
                        }
                        break;
                    case "down":
                        guy.Row++;
                        if (guy.Row >= n || guy.Row < 0)
                        {
                            Console.WriteLine("I do not need more swords!");
                            Console.WriteLine($"The king paid {sumSwords} gold coins.");
                            armory[guy.Row - 1, guy.Col] = '-';
                            PrintMatrix(armory);
                            return;
                        }
                        if (armory[guy.Row, guy.Col] == '-')
                        {
                            armory[guy.Row, guy.Col] = 'A';
                            armory[guy.Row - 1, guy.Col] = '-';
                        }
                        if ((int)armory[guy.Row, guy.Col] >= 49 && (int)armory[guy.Row, guy.Col] <= 57)
                        {
                            sumSwords += int.Parse(armory[guy.Row, guy.Col].ToString());
                            armory[guy.Row - 1, guy.Col] = '-';
                            armory[guy.Row, guy.Col] = 'A';
                        }
                        if (sumSwords >= 65)
                        {
                            Console.WriteLine("Very nice swords, I will come back for more!");
                            Console.WriteLine($"The king paid {sumSwords} gold coins.");
                            PrintMatrix(armory);
                            return;
                        }
                        if (armory[guy.Row, guy.Col] == 'M')
                        {
                            if (guy.Row == mirror1.Row && guy.Col == mirror1.Col)
                            {
                                guy.Row = mirror2.Row;
                                guy.Col = mirror2.Col;
                                armory[mirror1.Row, mirror1.Col] = '-';
                                armory[mirror1.Row - 1, mirror1.Col] = '-';
                                armory[guy.Row, guy.Col] = 'A';
                            }
                            else
                            {
                                guy.Row = mirror1.Row;
                                guy.Col = mirror1.Col;
                                armory[mirror2.Row, mirror2.Col] = '-';
                                armory[mirror2.Row - 1, mirror2.Col] = '-';
                                armory[guy.Row, guy.Col] = 'A';
                            }
                        }
                        break;
                    case "left":
                        guy.Col--;
                        if (guy.Col >= n || guy.Col < 0)
                        {
                            Console.WriteLine("I do not need more swords!");
                            Console.WriteLine($"The king paid {sumSwords} gold coins.");
                            armory[guy.Row, guy.Col + 1] = '-';
                            PrintMatrix(armory);
                            return;
                        }
                        if (armory[guy.Row, guy.Col] == '-')
                        {
                            armory[guy.Row, guy.Col] = 'A';
                            armory[guy.Row, guy.Col + 1] = '-';
                        }
                        if ((int)armory[guy.Row, guy.Col] >= 49 && (int)armory[guy.Row, guy.Col] <= 57)
                        {
                            sumSwords += int.Parse(armory[guy.Row, guy.Col].ToString());
                            armory[guy.Row, guy.Col + 1] = '-';
                            armory[guy.Row, guy.Col] = 'A';

                        }
                        if (sumSwords >= 65)
                        {
                            Console.WriteLine("Very nice swords, I will come back for more!");
                            Console.WriteLine($"The king paid {sumSwords} gold coins.");
                            PrintMatrix(armory);
                            return;
                        }
                        if (armory[guy.Row, guy.Col] == 'M')
                        {
                            if (guy.Row == mirror1.Row && guy.Col == mirror1.Col)
                            {
                                guy.Row = mirror2.Row;
                                guy.Col = mirror2.Col;
                                armory[mirror1.Row, mirror1.Col] = '-';
                                armory[mirror1.Row, mirror1.Col + 1] = '-';
                                armory[guy.Row, guy.Col] = 'A';
                            }
                            else
                            {
                                guy.Row = mirror1.Row;
                                guy.Col = mirror1.Col;
                                armory[mirror2.Row, mirror2.Col] = '-';
                                armory[mirror2.Row, mirror2.Col + 1] = '-';
                                armory[guy.Row, guy.Col] = 'A';
                            }
                        }
                        break;
                    case "right":
                        guy.Col++;
                        if (guy.Col >= n || guy.Col < 0)
                        {
                            Console.WriteLine("I do not need more swords!");
                            Console.WriteLine($"The king paid {sumSwords} gold coins.");
                            armory[guy.Row, guy.Col - 1] = '-';
                            PrintMatrix(armory);
                            return;
                        }
                        if (armory[guy.Row, guy.Col] == '-')
                        {
                            armory[guy.Row, guy.Col] = 'A';
                            armory[guy.Row, guy.Col - 1] = '-';
                        }
                        if ((int)armory[guy.Row, guy.Col] >= 49 && (int)armory[guy.Row, guy.Col] <= 57)
                        {
                            sumSwords += int.Parse(armory[guy.Row, guy.Col].ToString());
                            armory[guy.Row, guy.Col - 1] = '-';
                            armory[guy.Row, guy.Col] = 'A';
                        }
                        if (sumSwords >= 65)
                        {
                            Console.WriteLine("Very nice swords, I will come back for more!");
                            Console.WriteLine($"The king paid {sumSwords} gold coins.");
                            PrintMatrix(armory);
                            return;
                        }
                        if (armory[guy.Row, guy.Col] == 'M')
                        {
                            if (guy.Row == mirror1.Row && guy.Col == mirror1.Col)
                            {
                                guy.Row = mirror2.Row;
                                guy.Col = mirror2.Col;
                                armory[mirror1.Row, mirror1.Col] = '-';
                                armory[mirror1.Row, mirror1.Col - 1] = '-';
                                armory[guy.Row, guy.Col] = 'A';
                            }
                            else
                            {
                                guy.Row = mirror1.Row;
                                guy.Col = mirror1.Col;
                                armory[mirror2.Row, mirror2.Col] = '-';
                                armory[mirror2.Row, mirror2.Col - 1] = '-';
                                armory[guy.Row, guy.Col] = 'A';
                            }
                        }
                        break;
                }
                inputDirections = Console.ReadLine();
            }
        }
        public static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}