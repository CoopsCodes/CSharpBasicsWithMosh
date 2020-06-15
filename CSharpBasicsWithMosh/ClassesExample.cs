using System;
namespace CSharpBasicsWithMosh
{
    public class ClassesExample
    {
        public string Name;

        public string TestString()
        {
            return "Oh hey, my name is " + Name;
        }
    }
}

/* Classes are types that we create Objects from, they are building blocks of Object Orientated programming, 
 * that combine the related variables(fields) with Functions(methods).
 * -------------------
 * Class    - Person
 * 
 * Fields   - Name: String
 *          - Age: bite
 *          - Height: Float
 *          - Weight: Int
 *          
 * Methods  - Walk()
 *          - Talk()
 *          - Eat()
 *          - Sleep()
 * -------------------
 * 
 * Objects are an instance of a Class.
 * 
 * Static modifier used on a Class is used to define that only a single instance of that class is represented in the memory.
 * i.e. invoking an object of a class multiple times stores that invokation in a memory location every time, but if a Static
 * modifier is applied to the class it is always in the in memory location.
*/
