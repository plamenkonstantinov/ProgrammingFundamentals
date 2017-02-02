using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            for (int i = 0; i <= n-1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            var sum = 0;
            var min = int.MaxValue;
            var max = int.MinValue;
            for (int i = 0; i <= n-1; i++)
            {
                sum += arr[i];
                max = Math.Max(max, arr[i]);
                min = Math.Min(min, arr[i]);
            }


            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("First = " + arr[0]);
            Console.WriteLine("Last = " + arr[arr.Length-1]);
            Console.WriteLine("Average = " + (double)sum/n);
        }
    }
}
