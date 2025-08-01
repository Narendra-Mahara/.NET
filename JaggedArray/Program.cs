// Jagged array is the type of the array , where each element in the main array can have a different length 
// Jagged Array = array with unequal number of columns, unlike a normal array
          

using System;


namespace JaggedArray
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[3][];
            jarray[0] = new int[5] { 1, 2, 3, 4, 5 };
            jarray[1] = new int[3] { 6, 7, 8 };
            jarray[2] = new int[] { 9, 10, 11, 12, 13 };
            Console.WriteLine(jarray[0][4]); // first value is the array and second value is the position of the element in that array
        }
    }
}

