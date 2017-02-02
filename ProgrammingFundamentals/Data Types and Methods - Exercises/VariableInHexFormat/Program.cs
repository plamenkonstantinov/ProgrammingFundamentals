using System;


namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {

            string hexVariable = Console.ReadLine();
            int hexDecimal = Convert.ToInt32(hexVariable, 16);
            Console.WriteLine(hexDecimal);
        }
    }
}
