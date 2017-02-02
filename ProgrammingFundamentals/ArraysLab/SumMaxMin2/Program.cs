﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMaxMin2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            
            Console.WriteLine("Sum = " + arr.Sum());
            Console.WriteLine("Min = " + arr.Min());
            Console.WriteLine("Max = " + arr.Max());
            Console.WriteLine("First = " + arr.First());
            Console.WriteLine("Last = " + arr.Last());
            Console.WriteLine("Average = " + arr.Average());
        }
    }
}
