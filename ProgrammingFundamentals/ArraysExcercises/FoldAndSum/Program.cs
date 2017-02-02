using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] middleElements = new int[2 * k];
            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] = numbers[k + i];
            }
            int[] firstkElements = new int[k];
            for (int i = 0; i < firstkElements.Length; i++)
            {
                firstkElements[i] = numbers[i];
            }
            int[] lastkElements = new int[k];
            for (int i = 0; i < lastkElements.Length; i++)
            {
                firstkElements[i] = numbers[i+3*k];
            }
            Array.Reverse(firstkElements);
            Array.Reverse(lastkElements);

            int[] firstAndLastKElements = new int[k * 2];
            for (int i = 0; i < firstAndLastKElements.Length; i++)
            {
                if (i<k)
                {
                    firstAndLastKElements[i] = firstkElements[i];
                }
                else
                {
                    firstAndLastKElements[i] = lastkElements[i - k];
                }
            }
            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] += firstAndLastKElements[i];
            }
            Console.WriteLine(string.Join(" ", middleElements));
        }
    }
}
