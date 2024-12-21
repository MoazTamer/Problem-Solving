using System;
using System.Collections.Generic;
using System.IO;

class Result
{
    public static string IsBalanced(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '{' || c == '[' || c == '(')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return "NO";
                }

                char top = stack.Pop();
                if (!IsMatchingPair(top, c))
                {
                    return "NO";
                }
            }
        }

        return stack.Count == 0 ? "YES" : "NO";
    }

    private static bool IsMatchingPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '[' && close == ']') ||
               (open == '{' && close == '}');
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        using (TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true))
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();
                string result = Result.IsBalanced(s);
                textWriter.WriteLine(result);
            }
        }
    }
}
