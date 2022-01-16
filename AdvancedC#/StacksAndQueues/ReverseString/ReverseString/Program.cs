using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Name
{
    class Program
    {
        static void Main()
        {
            Stack<char> stack = new Stack<char>();
            string text = Console.ReadLine();
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                stack.Push(chars[i]);
            }
            string newText = "";
            for (int i = 0; i < chars.Length; i++)
            {
                newText += stack.Pop();
            }
            Console.WriteLine(newText);
        }
    }
}
