using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read1Row
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] items = input.Split(' ');
            int[] nums = items.Select(int.Parse).ToArray();

            Console.WriteLine("Sum = {0}", nums.Sum());
        }
    }
}
