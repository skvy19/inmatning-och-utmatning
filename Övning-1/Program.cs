using System;

namespace Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write something: ");
            string userName = Console.ReadLine();
            Console.WriteLine("You wrote: " + userName.ToUpper());
        }
    }
}
