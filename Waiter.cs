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

public static List<int> waiter(List<int> number, int q)
    {
        // function to generate primes numbers
        List<int> GeneratePrimes(int limit)
        {
            List<int> primes = new List<int>();
            int num = 2;
            while (primes.Count < limit)
            {
                bool isPrime = true;
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) primes.Add(num);
                num++;
            }
            return primes;
        }

        List<int> primes = GeneratePrimes(q);

        List<int> result = new List<int>();
        Stack<int> currentStack = new Stack<int>(number);

        for (int i = 0; i < q; i++)
        {
            Stack<int> nextStack = new Stack<int>(); 
            
            Stack<int> divisibleStack = new Stack<int>();

            while (currentStack.Count > 0)
            {
                int plate = currentStack.Pop();
                if (plate % primes[i] == 0)
                {
                    divisibleStack.Push(plate);
                }
                else
                {
                    nextStack.Push(plate);
                }
            }

            while (divisibleStack.Count > 0)
            {
                result.Add(divisibleStack.Pop());
            }

            currentStack = nextStack;
        }

        while (currentStack.Count > 0)
        {
            result.Add(currentStack.Pop());
        }

        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int q = Convert.ToInt32(firstMultipleInput[1]);

        List<int> number = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(numberTemp => Convert.ToInt32(numberTemp)).ToList();

        List<int> result = Result.waiter(number, q);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
