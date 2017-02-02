using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while (n.Length >= 2)
            {
                var result = new int[n.Length - 1];
                for (int i = 0; i < n.Length - 1; i++)
                {
                    result[i] = n[i] + n[i + 1];
                }
                n = result;
            }
        Console.WriteLine(n[0]);
        }
    }
}
