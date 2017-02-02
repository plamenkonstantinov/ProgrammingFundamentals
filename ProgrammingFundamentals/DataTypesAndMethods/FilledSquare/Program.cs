using System;


namespace Filled_Square
{
    class Filled_Square
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  
            PrintHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
                PrintMiddleRow(n);
            PrintHeaderRow(n);
        }
        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void PrintMiddleRow(int n)
        {
            string middleRow = "";
            for (int i = 0; i < n - 1; i++)
                middleRow += "\\/";
            Console.WriteLine("-{0}-", middleRow);
        }
    }
}