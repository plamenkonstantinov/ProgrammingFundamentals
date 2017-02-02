using System;
using System.Linq;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = Console.ReadLine()[0];
            if (char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else if ("aeiou".Contains(input))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
