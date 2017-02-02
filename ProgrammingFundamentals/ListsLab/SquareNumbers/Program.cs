using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var results = new List<int>();
            foreach (var n in numbers)
            {
                if (IsExactSquare(n))
                {
                    results.Add(n);
                }
            }
            results.Sort();
            results.Reverse();
            Console.WriteLine(string.Join(" ", results));
        }

        private static bool IsExactSquare(int n)
        {
            var sqrt = (int)Math.Sqrt(n);
            return (sqrt * sqrt == n);
            
        }
    }
}
