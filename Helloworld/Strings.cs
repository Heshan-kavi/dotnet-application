using System;
using System.Xml.Linq;
using System.Text;

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

        public static void StringConcatentaion()
        {
            var nameOne = "Heshan";
            var nameTwo = "Kavinda";
            var names = new string[2] { "Heshan", "Kavinda" };

            var contatinatedStringOne = nameOne + " " + nameTwo;                                            //usual contatination
            var contatinatedStringTwo = string.Format("{0} {1}", nameOne, nameTwo);                         //using format in string class for contatination
            var contatinatedStringThree = string.Join(" ", names);                                          //using join in string class for contatination with a sparator
            var textString = "hi John\nLook into the following path \nc:\\folder\\folders\\hello";          //usual string
            var textStringTwo = @"hi John
Look into the following path
c:\folder\folders\hello";                                                                                   //verbatim string


            Console.WriteLine("This is the contatinated string one : " + contatinatedStringOne);
            Console.WriteLine("This is the contatinated string two : " + contatinatedStringTwo);
            Console.WriteLine("This is the contatinated string three : " + contatinatedStringThree);
            Console.WriteLine("This is the second character in the contatinatestringone : " + contatinatedStringOne[1]);
            Console.WriteLine("This is the usual string with different string escape operators :");
            Console.WriteLine(textString);
            Console.WriteLine("This is the verbitam string without different string escape operators :");
            Console.WriteLine(textStringTwo);

        }

        public static void StringBuilderRelatedFunctionalities()
        {
            //comparison between strings and stringbuilder
            //when we modified a string it returns a new string everytime so it effects the performance but in string builders it returns the same string builder
            //but in string we can use some functions like index of, length and we cannot use these functionalities in stringbuilders

            var builder = new StringBuilder();

            builder.Append('-', 10);                            // to append ten - to the builder
            builder.AppendLine();                               //to append a newlint to the builder
            builder.Append("Hello Heshan");
            builder.AppendLine();
            builder.Append("----------");

            Console.WriteLine("This is the orginal string builder ; ");
            Console.WriteLine(builder);

            builder.Replace('-', '=');                          //to replace the - sign with a = equal sign
            Console.WriteLine("This is the string builder after replacing ; ");
            Console.WriteLine(builder);

            builder.Remove(0,12);                               //to remove characters from a starting index to end index
            Console.WriteLine("This is the string builder after removing ; ");
            Console.WriteLine(builder);

            builder.Insert(2, "world");                         //to insert a new string to a place with the mentioned starting index
            Console.WriteLine("This is the string builder inserting ; ");
            Console.WriteLine(builder);

        }
    }
}

