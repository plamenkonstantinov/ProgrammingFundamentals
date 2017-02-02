using System;


namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries =(byte) int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int) Math.Round(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);

        }
    }
}
