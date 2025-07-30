using System;


namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Narendra Mahara";
            int age = 23;
            bool isSingle = true;
            float bankBalance = 3037.29F;
            Console.WriteLine("Hello! my name is " + name + " and my age is " + age+". My bank balance is RS."+bankBalance);
            if (isSingle)
            {
                Console.WriteLine("I am single 😄");
            }

        }
    }
}

