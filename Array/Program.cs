using System;


namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marksObtained = [55, 60, 35, 42, 50];

            // for (int i = 0; i < marksObtained.Length; i++)
            // {

            //     Console.WriteLine(marksObtained[i]);
            // }
            
            //another loop to access elements of array
            foreach (int marks in marksObtained)
            {
                Console.WriteLine(marks);
            }

        }
    }
}

