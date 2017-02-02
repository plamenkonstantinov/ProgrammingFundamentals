using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text1 = Console.ReadLine().Split(' ');
            string[] text2 = Console.ReadLine().Split(' ');
            int smallestArrayLenght = Math.Min(text1.Length, text2.Length);
            int leftCounter = Counter(smallestArrayLenght, text1, text2);
            Array.Reverse(text1);
            Array.Reverse(text2);
            int RightCounter = Counter(smallestArrayLenght, text1, text2);
            Console.WriteLine(Math.Max(RightCounter,leftCounter));
        }

        private static int Counter(int smallestArrayLenght, string[] text1, string[] text2)
        {
            int counter = 0;
            for (int i = 0; i < smallestArrayLenght; i++)
            {
                if (text1[i] == text2[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }

        
    }
}
