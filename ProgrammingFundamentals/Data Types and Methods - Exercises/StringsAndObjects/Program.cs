using System;


namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            Console.WriteLine(string.Join(" ",text1,text2));
        }
    }
}
