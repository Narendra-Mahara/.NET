using System;

namespace ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
           string upperCaseName= name.ToUpper();
            Console.WriteLine("Your name is "+ upperCaseName);
        }
    }
}