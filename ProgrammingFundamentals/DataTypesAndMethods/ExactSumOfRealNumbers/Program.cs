using System;


namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal currNumber = decimal.Parse(Console.ReadLine());
                 sum+= currNumber;
            }
                Console.WriteLine(sum);

        }
    }
}
