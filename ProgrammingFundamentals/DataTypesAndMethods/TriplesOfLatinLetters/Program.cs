using System;


namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97+n; i++)
            {
                for (int i1 = 97; i1 < 97 + n; i1++)
                {
                    for (int i2 = 97; i2 < 97 + n; i2++)
                    {
                        Console.WriteLine("{0}{1}{2}", (char)i,(char)i1,(char)i2);
                    }
                }
            }
        }
    }
}
