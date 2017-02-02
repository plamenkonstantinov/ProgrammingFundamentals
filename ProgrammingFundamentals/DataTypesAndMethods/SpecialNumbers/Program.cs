using System;


namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var firstDigit = 0;
            var secondDigit = 0;
            for (int i = 1; i <= n; i++)
            {
                 secondDigit = i % 10;
                if (i<10)
                {
                    var fistDigit = i;
                }
                else
                {
                     firstDigit = i / 10;
                }

                if (firstDigit+secondDigit==5||firstDigit+secondDigit==7|| firstDigit + secondDigit == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
        }
    }
}
