// typeof casting in c# is a way to convert a variable from one type to another. This can be done using the (type) syntax or the as keyword. It's important to ensure that the conversion is valid to avoid runtime errors.

// there are two main types of casting in C#:
// 1. Implicit Casting: This is done automatically by the compiler when converting a smaller type to a larger type. e.g. char->int->long->float->double
// 2. Explicit Casting: This requires a cast operator to convert a larger type to a smaller type. e.g. double->float->long->int->char

using System;
namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Casting
            char charValue = 'A';
            int intValue1 = charValue; // char to int
            Console.WriteLine($"Implicit Casting: {charValue} to {intValue1}");
            int intValue = 123;
            long longValue = intValue; // int to long
            Console.WriteLine($"Implicit Casting: {intValue} to {longValue}");

            // Explicit Casting
            int intValue2 = 65;
            char castedCharValue = (char)intValue2; // int to char
            Console.WriteLine($"Explicit Casting: {intValue2} to {castedCharValue}");
            double doubleValue = 123.45;
            int castedIntValue = (int)doubleValue; // double to int
            Console.WriteLine($"Explicit Casting: {doubleValue} to {castedIntValue}");

            // Using 'as' keyword for safe casting
            object obj = "Hello, World!";
            string strValue = obj as string; // safe cast
            if (strValue != null)
            {
                Console.WriteLine($"Using 'as': {strValue}");
            }


            // Type Conversion Methods
            string numberString = "456";
            int number = 89;
            int convertedInt = Convert.ToInt32(numberString); // Convert method
            Console.WriteLine($"Converted string '{numberString}' to int: {convertedInt}");
            Console.WriteLine($"Converted int '{number}' to string: {number.ToString()}");

        }
    }
}
