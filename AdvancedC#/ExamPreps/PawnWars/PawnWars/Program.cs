using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace PawnWars
{
    class Program
    {
        static void Main()
        {
            Coordinates white = new Coordinates();
            Coordinates black = new Coordinates();
            Dictionary<int, char> map = new Dictionary<int, char>();
            map.Add(0, 'a');
            map.Add(1, 'b');
            map.Add(2, 'c');
            map.Add(3, 'd');
            map.Add(4, 'e');
            map.Add(5, 'f');
            map.Add(6, 'g');
            map.Add(7, 'h');
            char[,] board = new char[8, 8];
            for (int i = 0; i < 8; i++)
            {
                char[] rank = Console.ReadLine().ToCharArray();
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = rank[j];
                    if (rank[j] == 'w')
                    {
                        white.Row = i;
                        white.Col = j;
                    }
                    else if (rank[j] == 'b')
                    {
                        black.Row = i;
                        black.Col = j;
                    }
                }
            }

            while (true)
            {
                if (white.Row == 0)
                {
                    Console.WriteLine($"Game over! White pawn is promoted to a queen at {map[white.Col]}/8.");
                    break;
                }
                if (board[white.Row - 1, white.Col + 1] == 'b' || board[white.Row - 1, white.Col - 1]== 'b')
                {
                    Console.WriteLine($"Game over! White capture on {map[black.Col]}{8 - black.Row}.");
                    break;
                }
                board[white.Row, white.Col] = '-';
                board[white.Row - 1, white.Col] = 'w';
                white.Row--;

                if (black.Row == 7)
                {
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {map[black.Col]}/1.");
                    break;
                }
                if (board[black.Row + 1, black.Col + 1] == 'w' || board[black.Row + 1, black.Col - 1]== 'w')
                {
                    Console.WriteLine($"Game over! Black capture on {map[white.Col]}{8 - white.Row}.");
                    break;
                }
                board[black.Row, black.Col] = '-';
                board[black.Row + 1, black.Col] = 'b';
                black.Row++;
            }
        }
    }
    class Coordinates
    {
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
