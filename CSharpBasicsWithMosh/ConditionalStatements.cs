using System;
namespace CSharpBasicsWithMosh
{
    // Enum used for the Switch Statement
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

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

        public void ConditionalOperator()
        {
            // A shorter hand form of an if statement written in a single line.
            // This example uses the if statement without the curly braces,
            // can ONLY be used if the code within the if statemend is only one line.

            // Tradition basic if statement.
            bool isGoldCustomer = true;

            float price;

            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            // Can be rewitten as a Conditional Operator
            // Yes it is almost identical to a Ternary Operator in Javascript
            float conditionalPrice = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine("Price: " + price);
            Console.WriteLine("Conditional Price" + conditionalPrice);
        }

        public void SwitchStatement()
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("This switch will run for both Autumn and Spring");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's Summer");
                    break;

                case Season.Winter:
                    Console.WriteLine("It's Winter");
                    break;

                default:
                    Console.WriteLine("Incorrect Input, please try again.");
                    break;
            }
        }
    }
}
