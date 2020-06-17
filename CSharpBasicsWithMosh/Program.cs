using System;
using System.Collections.Generic;

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
    }
}

