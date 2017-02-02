using System;


namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float speedMSec = (float)distance / (seconds + minutes * 60f + hours * 60f * 60f);
            float speedKmpH = (float)distance / 1000f / (hours + minutes / 60f + seconds / 60f / 60f);
            float speedMpH = (float)distance / 1609f / (hours + minutes / 60f + seconds / 60f / 60f);

            Console.WriteLine("{0}", speedMSec);
            Console.WriteLine("{0}", speedKmpH);
            Console.WriteLine("{0}", speedMpH);

        }
    }
}
