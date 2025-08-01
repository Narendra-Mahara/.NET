// A multidimensional array is basically an array of arrays.
//  The single comma [,] specifies that the array is two-dimensional. A three-dimensional array would have two commas: int[,,].

using System;


namespace MultiDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] superHeroes = { { "Thor", "SpiderMan" }, { "Batman", "Narendra" } };
            // Console.WriteLine(superHeroes[1, 1]);  //First value is the array and second value is the position of the element inside that array

            // Console.WriteLine(superHeroes.GetLength(0)); // to get the length of the array inside the two-dimensional array

            //We can iterate through the two-dimensional array using foreach loop
            foreach (string superHero in superHeroes)
            {
                Console.WriteLine(superHero);
            } 

        }   
    }
}

