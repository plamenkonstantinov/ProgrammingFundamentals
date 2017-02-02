using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var list = new List<int>();
            foreach (var n in nums)
            {
                if (n>=0)
                {
                    list.Add(n);
                }
            }
            list.Reverse();
            if (list.Count>0)
            {

            Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
