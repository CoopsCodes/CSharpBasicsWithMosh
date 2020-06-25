using System;

namespace CSharpBasicsWithMosh
{
    public enum Seasons
    {
        Spring = 1,
        Summer = 2,
        Autumn = 3,
        Winter = 4
    }

    public class EnumMethods
    {
        public static void TestEnum()
        {
            // Grabbing the enum value
            var grabEnum = Seasons.Winter; // Assign the enum
            // Use 'Casting' to convert the enum to an int
            Console.WriteLine((int)grabEnum); // output => 4

            // Recalling an enum by number
            int enumNumber = 3;
            // Cast the enum and pass in the number location required
            Console.WriteLine((Seasons)enumNumber); // outcome => "Autumn"

            // Parse (changing data type) to an enum
            string convertSeason = "Spring";
            // convertedEnum is (casting) the Enum.Parse method and grabbing the typeof Season(ie and enum)
            // and passing in the string to convert.
            var convertedEnum = (Seasons) Enum.Parse(typeof (Seasons), convertSeason);
            Console.WriteLine(convertedEnum);
        }
    }
    
}

/* Enumeration is a value type defined by a set of named constants 
 * of the underlying integral numeric types (i.e bite, short, int, long).
 * 
 * By default an Enum are of type 'int' if not defined.
 * 
*/