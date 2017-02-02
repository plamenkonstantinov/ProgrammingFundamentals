using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ').ToArray();
            var result = new string[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                result[items.Length - i - 1] = items[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
