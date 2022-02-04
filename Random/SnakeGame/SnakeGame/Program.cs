using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace SnakeGame
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(100, 40);
            
            Console.BackgroundColor = ConsoleColor.White;
            // Upper wall
            for (int i = 1; i < 100; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write((char)3);

            }
            // Lower wall
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(i, 39);
                Console.Write((char)3);

            }
            //Right wall
            for (int i = 39; i >= 0; i--)
            {
                Console.SetCursorPosition(0, i);
                Console.Write((char)3);

            }
            //Left wall
            for (int i = 39; i >= 0; i--)
            {
                Console.SetCursorPosition(99, i);
                Console.Write((char)3);

            }
            Console.BackgroundColor = ConsoleColor.Black;
            
            Console.SetCursorPosition((int)0, 40);
            Console.ReadKey();
        }
    }
}