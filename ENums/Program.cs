// An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
// We can access enum items with the dot(.) syntax:
// By default, the first item of an enum has the value 0. The second has the value 1, and so on.
// Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.



namespace Enums
{
    enum Level
    {
        Low=8,
        Medium, // 9
        High // 10
    }

    class Program
    {
        static void Main(string[] args)
        {
            int myVar =(int) Level.Medium;
            Console.WriteLine(myVar);
        }
    }

}