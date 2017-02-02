﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var len = Math.Max(arr1.Length, arr2.Length);
          
            var result = new int[len];
            for (int i = 0; i < len; i++)
            {
                result[i] = arr1[i%arr1.Length] + arr2[i%arr2.Length];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
