using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isIndexFound = false;
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                for (int i = currentElement+1; i < numbers.Length; i++)
                {
                    sumRight += numbers[i];
                }
                for (int i = 0; i < currentElement; i++)
                {
                    sumLeft += numbers[i];
                }
                if (sumLeft==sumRight)
                {
                    Console.WriteLine(currentElement);
                    isIndexFound = true;
                    break;
                }

            }
                if (!isIndexFound)
                {
                    Console.WriteLine("no");
                }        
        }
    }
}
