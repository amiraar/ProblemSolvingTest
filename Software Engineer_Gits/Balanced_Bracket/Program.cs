using System;
using System.Collections.Generic;

public class Programmss
{
    public static bool IsBalancedBracket(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char bracket in input)
        {
            if (bracket == '(' || bracket == '[' || bracket == '{')
            {
                stack.Push(bracket);
            }
            else if (bracket == ')' || bracket == ']' || bracket == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                char lastBracket = stack.Pop();
                if ((bracket == ')' && lastBracket != '(') ||
                    (bracket == ']' && lastBracket != '[') ||
                    (bracket == '}' && lastBracket != '{'))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            string result = IsBalancedBracket(input) ? "YES" : "NO";
            Console.WriteLine("Output: " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine("Terjadi kesalahan: " + e.Message);
        }
    }
}
