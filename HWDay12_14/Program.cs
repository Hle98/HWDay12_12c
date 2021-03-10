using System;
using System.Collections.Generic;

namespace HWDay12_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<int>();
            Sum(10);
        }
        static void Sum(int sum)
        {
            var result = new List<int>();
            Sum(sum, result);
        }
        static void Sum(int sum, List<int> result)
        {
            int max = sum;
            if (sum == 0)
            {
                PrintList(result);
                return;
            }
            if (result.Count != 0)
            {
                if (result[result.Count - 1] < sum)
                {
                    max = result[result.Count - 1];
                }
            }
            for (int n =max;n>0;n--)
            {
                result.Add(n);
                Sum(sum - n, result);
                result.Remove(n);
            }
        }
        static void PrintList(List<int> result)
        {
            if (result.Count == 1)
            {
                Console.WriteLine(result[0]);
            }
            else
            {
                for (int i = 0; i < result.Count - 1; i++)
                {
                    Console.Write(result[i] + "+");
                }
                Console.WriteLine(result[result.Count - 1]);
            }
        }
    }
}



