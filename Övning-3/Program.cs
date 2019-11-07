using System;

namespace Övning_3
{
    class Program
    {
        static string userInputs() {
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Ange det första förnamnet: ");
            string firstName_User1 = userInputs();
            Console.Write("Ange det första efternamnet: ");
            string secondName_User1 = userInputs();
            Console.WriteLine("************************");

            Console.Write("Ange det andra förnamnet: ");
            string firstName_User2 = userInputs();
            Console.Write("Ange det andra efternamnet: ");
            string secondName_User2 = userInputs();
            Console.WriteLine("************************");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            string story = firstName_User1 + " " + secondName_User1 + " och " + firstName_User2 + " " + secondName_User2 + " är gifta";
            Console.WriteLine(story);

        }
    }
}
