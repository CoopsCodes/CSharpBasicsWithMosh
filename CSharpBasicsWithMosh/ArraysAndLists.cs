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

        // A 2D array that has an uneven number of lenths.
        public void JaggardArray()
        {
            // Invoke a new jaggard array without declaring the second array size.
            int[][] jaggard = new int[3][];
            // Filling the array.   
            jaggard[0] = new int[3];
            jaggard[1] = new int[6];
            jaggard[2] = new int[4];
        }

        public void FunWithArrays()
        {
            // var nums = new[] { 2, 4, 6, 8, 10, 1, 3, 5, 7, 9 }; // An alternative to declaring an array using var.
            int[] nums = new int[] { 2, 4, 6 , 8, 10, 1, 3, 5, 7, 9};

            // .Length
            // provides the total number of objects in the array.
            Console.WriteLine("Length: " + nums.Length); // output => 10;

            // Indexof()
            // provides the index location of a chosen
            var numIndex = Array.IndexOf(nums, 7); // output => 8

            // Clear()
            // clears sections of an array, takes 3 paramaters:
            // the Array name, then the index number to start clearing, and the length or number of elements needed to clear
            // depending on the type, they arent deleted, they're set to default values,
            // so fo a number array they're set to 0s
            // i.e an array of strings will be set to null
            Array.Clear(nums, 0, 2); // output => 0, 0, 6 , 8, 10, 1, 3, 5, 7, 9

            // Copy()
            // copies elements of an array into another.
            // takes 3 paramaters:
            // the array to copy, the array to copy to, and the numbers to be copied over.
            // starts from index point 0
            int[] copyArray = new int[3];
            Array.Copy(nums, copyArray, 3);

            // Sort()
            // sorts an array
            Array.Sort(nums); // output => 1, 2, 3, 4, 5, 6, 7, 8, 9, 10

            // Reverse()
            // reverses the array... duh
            Array.Sort(nums); // output => 10, 9, 8, 7, 6, 5, 4, 3, 2, 1
        }
    }
}
