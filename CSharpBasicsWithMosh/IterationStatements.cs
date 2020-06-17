using System;

namespace CSharpBasicsWithMosh
{
    public class IterationStatements
    {
        public void ForLoop()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine("Even Numbers: " + i);
                }
            }

            for (int j = 10; j >= 1 ; j--)
            {
                if (j%2 == 0)
                {
                    Console.WriteLine("Even Numbers in reverse: " + j);
                }
            }
        }

        public void ForEachLoop()
        {
            string name = "Cooper Viktor";

            // iterates over the string and prints each on an individual line.
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            // ForEach iterates in a similar way, item is the index location of each iteration.
            // Much more efficient for iterating over an array of items.
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
        }

        public void WhileLoop()
        {
            // While will operate as long as the contition is true.
            int i = 0;
            while (i < 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even Numbers" + i);

                i++;
            }

            // Another Example
            Console.WriteLine("Please Enter Your Name: ");
            string input = Console.ReadLine();

            while (true) 
            {
                if (!string.IsNullOrWhiteSpace(input)) // checking if input is NOT null or whitespace
                {
                    Console.WriteLine("@Echo: " + input);
                    continue; // Continue rolls the iteration back to the start without breaking out of it
                }

                break; // Break will END the while loop.
            }
        }
    }
}
