using System;
namespace Helloworld
{
	public class TimeSpanClass
	{
		public static void TimeSpanRelatedFunctionalities()
		{
            var timespan = new TimeSpan(1, 2, 3);                                                                           //create a timespan with 1hour 2mins and 3secs.
            var timespan1 = new TimeSpan(1, 0, 0);                                                                          //create a timespan with one hour
            var timespan2 = TimeSpan.FromHours(1);                                                                          //create a timespan with one hour

            Console.WriteLine("this is the created timespan : " + timespan);
            Console.WriteLine("this is the minutes of the the created timespan : " + timespan.Minutes);                                 //to get the only minutes in the timespan
            Console.WriteLine("this is the total minutes of the created timespan : " + timespan.TotalMinutes);                          //to get the timespan with minutes
            Console.WriteLine("this is the timespan after adding a day of timespan : " + timespan.Add(TimeSpan.FromDays(1)));           //to add days to the timestamp
            Console.WriteLine("this is the timespan after subtracting one hour to it : " + timespan.Subtract(TimeSpan.FromHours(1)));   //to substract hours from the timestamp
        }
	}
}

