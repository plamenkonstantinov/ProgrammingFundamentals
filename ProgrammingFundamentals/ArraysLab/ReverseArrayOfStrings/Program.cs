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
            var reversedItems = items.Reverse();
            Console.WriteLine(string.Join(" ", reversedItems));
        }
    }
}
