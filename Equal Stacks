using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
    {
        Stack<int> stack1 = new Stack<int>(h1.AsEnumerable().Reverse());
        Stack<int> stack2 = new Stack<int>(h2.AsEnumerable().Reverse());
        Stack<int> stack3 = new Stack<int>(h3.AsEnumerable().Reverse());

        int sum1 = stack1.Sum();
        int sum2 = stack2.Sum();
        int sum3 = stack3.Sum();

        while (!(sum1 == sum2 && sum2 == sum3))
        {
            if (sum1 >= sum2 && sum1 >= sum3)
            {
                sum1 -= stack1.Pop();
            }
            else if (sum2 >= sum1 && sum2 >= sum3)
            {
                sum2 -= stack2.Pop();
            }
            else if (sum3 >= sum1 && sum3 >= sum2)
            {
                sum3 -= stack3.Pop();
            }
        }
        return sum1;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n1 = Convert.ToInt32(firstMultipleInput[0]);

        int n2 = Convert.ToInt32(firstMultipleInput[1]);

        int n3 = Convert.ToInt32(firstMultipleInput[2]);

        List<int> h1 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h1Temp => Convert.ToInt32(h1Temp)).ToList();

        List<int> h2 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h2Temp => Convert.ToInt32(h2Temp)).ToList();

        List<int> h3 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h3Temp => Convert.ToInt32(h3Temp)).ToList();

        int result = Result.equalStacks(h1, h2, h3);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
