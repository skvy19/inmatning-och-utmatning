using System;

namespace Övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange förnamn: ");
            string firstName = Console.ReadLine();
            Console.Write("Ange efternamn: ");
            string lastName = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("**************************************");
            Console.WriteLine(" ");
            Console.WriteLine("Hello, " + firstName.ToUpper() + " " + lastName.ToUpper());
        }
    }
}
