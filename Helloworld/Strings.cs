using System;
using System.Xml.Linq;

namespace Helloworld
{
	public class Strings
	{
		public static void FormatingFunctionalities()
		{
            var name = "Heshan Kavinda ";

            Console.WriteLine("Orginal string : '{0}'", name);
            Console.WriteLine("Trimmed string : '{0}' ", name.Trim());                                 //trim the string
            Console.WriteLine("Uppercased string : '{0}' ", name.Trim().ToUpper());                     //to convert the string to uppercase string
            Console.WriteLine("Lowercased string : '{0}' ", name.Trim().ToLower());                     //to convert the string to lowervase string
        }

        public static void OtherFunctionalities()
        {
            var name = "Heshan Kavinda";
            var index = name.IndexOf('s');
            var firstName = name.Trim().Substring(0, 6);
            var lastName = name.Trim().Substring(7);

            Console.WriteLine("the index of letter 's' in the string is : '{0}'", index);               //to get the index of a character in the string
            Console.WriteLine("the first name is : '{0}' ", firstName);                                 //to get a substring using the index and the length
            Console.WriteLine("the last name is : '{0}' ", lastName);                                   //to get a substring using only the index

            var names = name.Split(' ');                                                                //split the whole string with the character which we provided
            Console.WriteLine("the first name is : '{0}' ", names[0]);                                  //to get a substring using the split
            Console.WriteLine("the last name is : '{0}' ", names[1]);                                   //to get a substring using the split

            Console.WriteLine("Replaced s with $ in the string : '{0}'", name.Replace('s', '$'));               //replace characters in the string
            Console.WriteLine("Replaced esh with ESH in the string : '{0}'", name.Replace("esh", "ESH"));       //replace strings in the string

            var ageInString = "26";
            Console.WriteLine("This is the parsed age value by using parse : " + Byte.Parse(ageInString));          //converting string to byte using parse
            Console.WriteLine("This is the parsed age value by using convert : " + Convert.ToByte(ageInString));    //converting string to byte using convert


            var sentence = "This text is going going to be really really really really really really long for the testing purposes!";
            var maxLength = 32;

            var returnedSummarizedString = Helloworld.StringUtilization.SummerizingText(sentence, maxLength);
            Console.WriteLine("this is the summerized string : ");
            Console.WriteLine(returnedSummarizedString);
        }
	}
}

