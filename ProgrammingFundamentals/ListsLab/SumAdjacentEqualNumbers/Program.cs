using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            var sum = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i-1]==numbers[i])
                {
                    numbers[i - 1] += numbers[i];
                    numbers.RemoveAt(i);
                    i = 0;
                }
            
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
