using System;


namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = Console.ReadLine()[0];
            long id = long.Parse(Console.ReadLine());
            int uen = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", id);
            Console.WriteLine("Unique Employee number: {0}", uen);
        }
    }
}
