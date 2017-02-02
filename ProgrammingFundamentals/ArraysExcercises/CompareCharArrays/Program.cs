using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int smallerArrayLenght = Math.Min(firstArray.Length, secondArray.Length);
            bool areEqual = false;
            for (int i = 0; i < smallerArrayLenght; i++)
            {
                if (firstArray[i]==secondArray[i])
                {

                }
                else
                {
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine(firstArray);
                        Console.WriteLine(secondArray);
                    }
                    else
                    {
                        Console.WriteLine(secondArray);
                        Console.WriteLine(firstArray);
                    }
                    areEqual = true;
                    break;
                }
            }
            if (!areEqual)
            {
                if (firstArray.Length<=secondArray.Length)
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                }
                else
                {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                }
            }
        }
    }
}
