using System;
using System.Collections.Generic;
using System.IO;

class Result
{
    public static List<int> getMax(List<string> operations)
    {
        var stack = new Stack<int>();
        var maxStack = new Stack<int>();
        var results = new List<int>();

        foreach (var operation in operations)
        {
            var parts = operation.Split(' ');
            int command = int.Parse(parts[0]);

            switch (command)
            {
                case 1: // Push
                    int value = int.Parse(parts[1]);
                    stack.Push(value);
                    if (maxStack.Count == 0 || value >= maxStack.Peek())
                    {
                        maxStack.Push(value);
                    }
                    break;
                case 2: // Pop
                    if (stack.Pop() == maxStack.Peek())
                    {
                        maxStack.Pop();
                    }
                    break;
                case 3: // Print max
                    results.Add(maxStack.Peek());
                    break;
            }
        }

        return results;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        using (var textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true))
        {
            int n = int.Parse(Console.ReadLine().Trim());
            var operations = new List<string>();

            for (int i = 0; i < n; i++)
            {
                operations.Add(Console.ReadLine());
            }

            var results = Result.getMax(operations);
            textWriter.WriteLine(string.Join("\n", results));
        }
    }
}
