using System;


namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Narendra Mahara";
            int age = 23;
            float bankBalance = 3037.29F;
            // Console.WriteLine("Hello! my name is " + name + " and my age is " + age+". My bank balance is RS."+bankBalance);


            // string interpolation
            Console.WriteLine($"Hello! my name is{name} and my age is {age}. My bank balance is RS.{bankBalance}");

            // string length
            Console.WriteLine(name.Length);

            //Indexof and Subtring

            int charPos = name.IndexOf("d");
            string substr = name.Substring(charPos);  // Substring return the part of the string starting from the given position
            Console.WriteLine(substr); 
            


        }
    }
}

