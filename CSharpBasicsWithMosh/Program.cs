using System;

namespace CSharpBasicsWithMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassesExample test = new ClassesExample(); // Invoking an object of the ClassesExample.
            //var test = new ClassesExample(); => can also be defined with the Var declaration
            test.Name = "Cooper"; // Assigning a string to the Name variable decalred in the ClassesExamples Class.
            test.TestString(); // Calling the method within the class => ""Oh hey, my name is Cooper"
        }

        static void Random()
        {
            var random = new Random();

            for (int i = 0; i < 10; i++)
                Console.WriteLine(random.Next()); // Next returns a non negative integer

            for (int i = 0; i < 10; i++)
                Console.WriteLine(random.Next(1, 10));  // Next can take a min and max param,
                                                        // this will only generate a number between 1 and 10
        }

        static void RandomPassword()
        {
            var random = new Random();
            int passwordLength = 10;
            char[] buffer = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            string password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}

