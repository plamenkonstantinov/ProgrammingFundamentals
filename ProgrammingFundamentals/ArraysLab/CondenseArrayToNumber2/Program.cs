using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArrayToNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int r = 0; r < n.Length-1; r++)
            {
                for (int i = 0; i < n.Length-1; i++)
                {
                    n[i] = n[i] + n[i + 1];
                }
            }
            Console.WriteLine(n[0]);
        }
    }
}
