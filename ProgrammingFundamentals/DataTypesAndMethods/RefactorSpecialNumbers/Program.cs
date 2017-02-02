using System;


namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0; int takova = 0; bool toe = false;
            for (int ch = 1; ch <= n; ch++)
            {
                takova = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                toe = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{takova} -> {toe}");
                sum = 0;
                ch = takova;
            }

        }
    }
}
