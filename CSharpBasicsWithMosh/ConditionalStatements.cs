using System;
namespace CSharpBasicsWithMosh
{
    public class ConditionalStatements
    {
        public void IfStatement()
        {
            // If Statements check if a condition is true and process it

            // The statement being checked
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It is morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It is Afternoon");
            }
            else
            {
                Console.WriteLine("It is Night");
            }
        }
    }
}
