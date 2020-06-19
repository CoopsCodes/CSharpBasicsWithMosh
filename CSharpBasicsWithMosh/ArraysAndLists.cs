using System;
namespace CSharpBasicsWithMosh
{
    public class ArraysAndLists
    {
        // Multidimensional Array
        public void RectangularArray()
        {
            // A 2D array needs to be declared like a traditional array
            int[,] standardMatrix = new int[3, 5]; // Declaring a new 3x5 2D array

            // if the contents are known it can be added as follows.
            int[,] matrix = new int[3, 5]
            {
                {1, 2, 3, 4, 5 },
                {6, 7, 8, 9, 10 },
                {11, 12, 13, 14, 15 }
            };

            // To access an element in the array.
            int element = matrix[1, 2]; // output => 8; The first number is the X axis(up/down) and the second number is Y axis(left/right)
            Console.WriteLine(element);
        }
    }
}
