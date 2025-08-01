// A method is a block of code which only runs when it is called.
using System;


namespace Methods
{
    static class Program
    {
        static void MyMethod(string name="K")  //default value
        {
            Console.WriteLine("My name is : "+name);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            MyMethod("Narendra"); //passing data, known as parameters, into a method.
            MyMethod("S");

            int value = Add(19, 29);
            Console.WriteLine("The sum of 19 and 29 is :" + value);        }
    }
}

