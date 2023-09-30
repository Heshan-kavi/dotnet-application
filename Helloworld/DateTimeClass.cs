using System;
namespace Helloworld
{
	public class DateTimeClass
	{
		public static void DateTimeRelatedFunctionalities()
		{
            var dateTime = new DateTime(2015, 01, 01);                                                                        //to access the datatime class
            var now = DateTime.Now;
            var tomorrow = now.AddDays(1);                                                                                  //to get tomorrow date
            var yesterday = now.AddDays(-1);                                                                                //to get yesterday date

            Console.WriteLine("This is today : " + now);
            Console.WriteLine("This is yesterday : " + yesterday);
            Console.WriteLine("This is tomorrow : " + tomorrow);
            Console.WriteLine("This is the today time in short format : " + now.ToShortTimeString());                       //to get the today time in short format
            Console.WriteLine("This is the today time in long format : " + now.ToLongTimeString());                         //to get the today time in long format
            Console.WriteLine("This is the today date in short format : " + now.ToShortDateString());                       //to get the today date in short format
            Console.WriteLine("This is the today date in long format : " + now.ToLongDateString());                         //to get the today date in long format
            Console.WriteLine("This is the today date in diff format : " + now.ToString("yyyy-MM-dd"));                     //to get the today date in diff format

        }
    }
}

