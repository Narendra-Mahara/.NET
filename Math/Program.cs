// The C# Math class has many methods that allows to perform mathematical tasks on numbers.
// Math.Max(x,y), Math.Min(x,y), Math.Sqrt(x), Math.Abs(x), Math.Round(x) Math.Pow(x,y) are some of the methods that can be used.

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Max(5, 10): " + Math.Max(a, b));
            Console.WriteLine("Min(5, 10): " + Math.Min(a, b));
            Console.WriteLine("Square root of 16: " + Math.Sqrt(16));
            Console.WriteLine("Absolute value of -5: " + Math.Abs(-5));
            Console.WriteLine("Round 4.7: " + Math.Round(4.7));
            Console.WriteLine("2 raised to the power of 3: " + Math.Pow(2, 3));
        }
    }
}