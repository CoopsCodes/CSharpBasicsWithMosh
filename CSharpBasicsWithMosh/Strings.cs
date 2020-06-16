using System;
namespace CSharpBasicsWithMosh
{
    public class Strings
    {
        public Strings()
        {
            // String Literal
            string stringLiteral = "Cooper";
            Console.WriteLine("String Litreral: " + stringLiteral);

            // Verbatim String Literal
            // an @ sign is used to prefix the string to indicate direct paths without escape characters being read i.e. '/'
            string verbatim = @"c:\Program Files\Microsoft Visual Studio 9.0";
            Console.WriteLine("Verbatim: " + verbatim);

            // Format Strings
            // String Interpolation
            // identified with the '$' character preceeding the string.
            var SI = (firstName: "Cooper", lastName: "Viktor", DOB: 1984);
            Console.WriteLine($"My name is {SI.firstName} {SI.lastName}, and I was born in {SI.DOB}.");

            // Composite Formatting
            // Similar so String Interpolation, takes in a curly brace with a number location that corresponds
            // with the locations declared after the string. does not use the '$' character.
            var CF = (firstName: "Cooper", lastName: "Viktor", DOB: 1984);
            Console.WriteLine("My name is {0} {1}, and I was born in {2}.", CF.firstName, CF.lastName, CF.DOB);

            // Substrings
            // A method that creates a new string and perform operations on it.
            string SS = "Strings in C#";
            // takes the index number and the number of characters and created a new string
            Console.WriteLine(SS.Substring(0, 6)); // output => "String"
            // replaces the first string param with the second.
            Console.WriteLine(SS.Replace("C#", "C++")); // output => "Strings in C++"

            // Join
            // Used to concat and format, i.e can be used to format a list of names in a string array.
            string[] names = new string[3] { "Cooper", "Andy", "Gwenny" };
            string formattedNames = String.Join(", ", names);
            // this will concat them all the strings together and join them with ', '
            Console.WriteLine(formattedNames); // output => "Cooper, Andy, Gwenny"
        }
    }
}

// Strings are immutable so cannot be changed afer declarationg (could be a Const declaration if needed),
// modifying strings will always create a new string with the original being referenced rather than mutated.
