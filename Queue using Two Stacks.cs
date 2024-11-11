using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        for (int i = 0; i < q; i++)
        {
            string[] query = Console.ReadLine().Split();
            int type = int.Parse(query[0]);

            if (type == 1)
            {
                int x = int.Parse(query[1]);
                stack1.Push(x);
            }
            else if (type == 2)
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }
                if (stack2.Count > 0)
                {
                    stack2.Pop();
                }
            }
            else if (type == 3)
            {
                if (stack2.Count == 0)
                {
                    while (stack1.Count > 0)
                    {
                        stack2.Push(stack1.Pop());
                    }
                }
                if (stack2.Count > 0)
                {
                    Console.WriteLine(stack2.Peek());
                }
            }
        }
    }
}
