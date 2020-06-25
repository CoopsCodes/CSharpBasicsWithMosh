using System;

namespace CSharpBasicsWithMosh
{
    public class TimeClass
    {
        public void DateTimeObjects()
        {
            DateTime date = new DateTime(2020,1,1);
            DateTime now = DateTime.Now; // displays current datetime
            DateTime today = DateTime.Today; // displays the current day

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Min: " + now.Minute);

            // DateTime is immutible, to make changes you need to use certain methods.
            DateTime tomorrow = now.AddDays(1);
            Console.WriteLine("Tomorrow is " + tomorrow); // will add a day.
            DateTime yesterday = now.AddDays(-1);
            Console.WriteLine("Yesterday was " + yesterday); // will take a day away

            // will display long and short versions of the Date string
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());

            // will display long and short versions of the Time string
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongTimeString());

            // To display date plus time
            Console.WriteLine(now.ToString());
            // Comes with many format options
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
