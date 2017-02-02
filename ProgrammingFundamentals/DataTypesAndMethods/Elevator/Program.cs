using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int cources = (int)Math.Ceiling((double)n / c);

            Console.WriteLine(cources);
        }
    }
}
