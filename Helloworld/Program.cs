using System;
using Helloworld.Math;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Variables
{

    public enum TestingEnum
    {
        RegularAirMail = 1,
        RegiseredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            //byte number = 23;
            //float totalPrice = 23.22f;
            //bool isWorking = true;

            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine(number);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(isWorking);

            //check type conversions
            //explicit conversion
            //int testingvalue = 260;
            //byte testingValueTwo = (byte) testingvalue;
            //Console.WriteLine("this is the value in int type :  {0}", testingvalue);
            //Console.WriteLine("this is the value in byte type :  {0}", testingValueTwo);

            //implicit conversion
            //int testingValueThree = 260;
            //float testingValueFour = testingValueThree;
            //Console.WriteLine("this is the value in int type :  {0}", testingValueThree);
            //Console.WriteLine("this is the value in float type :  {0}", testingValueFour);

            //non-compatible conversion
            //string testingValueFive = "12";
            //float testingValueSix = Convert.ToInt16(testingValueFive);
            //float testingValueSeven = int.Parse(testingValueFive);
            //Console.WriteLine("this is the value in string type :  {0}", testingValueSix);
            //Console.WriteLine("this is the value in int type with convert function :  {0}", testingValueSix);
            //Console.WriteLine("this is the value in int type with parse function :  {0}", testingValueSeven);


            //using try and catch
            //try
            //{
            //    var stingValueEight = "1234";
            //    byte b = Convert.ToByte(stingValueEight);
            //    //Console.WriteLine(b);

            //}
            //catch (Exception)
            //{
            //    //Console.WriteLine("there is a type conversion issue with the values !!!");
            //}


            //operators
            //arithmetic operators
            //var testingValueNine = 12;
            //var testingValueTen = 23;

            //Console.WriteLine((float)testingValueNine + (float)testingValueTen);
            //Console.WriteLine(testingValueTen > testingValueNine);
            //Console.WriteLine(!(testingValueTen > testingValueNine));




            //Checking non-primitve types in the C#
            //Person person = new Person();
            //person.FirstName = "Heshan";
            //person.Secondname = "Kavinda";
            //person.age = 23;
            //person.address = "Meegoda";
            //var fullName = person.Introduce();
            //Console.WriteLine("this is the full name : " + fullName);

            //testing a class which is located in a different field
            //Calculator calculator = new Calculator();
            //Console.WriteLine("This is the resulf from the cal : " + calculator.AddNumbers(12, 23));



            //testing array
            //var numberArray = new int[3];
            //numberArray[0] = 1;

            //Console.WriteLine(numberArray[0]);
            //Console.WriteLine(numberArray[1]);
            //Console.WriteLine(numberArray[2]);

            //var booleanArray = new bool[3];
            //booleanArray[0] = true;

            //Console.WriteLine(booleanArray[0]);
            //Console.WriteLine(booleanArray[1]);
            //Console.WriteLine(booleanArray[2]);

            //var stringArray = new string[3] { "hens", "kavi", "nimal" };

            //Console.WriteLine(stringArray.Length);



            //strings and related things
            //            var nameOne = "Heshan";
            //            var nameTwo = "Kavinda";
            //            var names = new string[2] { "Heshan", "Kavinda" };

            //            var contatinatedStringOne = nameOne + " " + nameTwo;                                            //usual contatination
            //            var contatinatedStringTwo = string.Format("{0} {1}", nameOne, nameTwo);                         //using format in string class for contatination
            //            var contatinatedStringThree = string.Join(" ", names);                                          //using join in string class for contatination with a sparator
            //            var textString = "hi John\nLook into the following path \nc:\\folder\\folders\\hello";          //usual string
            //            var textStringTwo = @"hi John
            //Look into the following path
            //c:\folder\folders\hello";                                                                                   //verbatim string


            //Console.WriteLine("This is the contatinated string one : " + contatinatedStringOne);
            //Console.WriteLine("This is the contatinated string two : " + contatinatedStringTwo);
            //Console.WriteLine("This is the contatinated string three : " + contatinatedStringThree);
            //Console.WriteLine("This is the second character in the contatinatestringone : " + contatinatedStringOne[1]);
            //Console.WriteLine("This is the usual string with different string escape operators :");
            //Console.WriteLine(textString);
            //Console.WriteLine("This is the verbitam string without different string escape operators :");
            //Console.WriteLine(textStringTwo);




            //Enum related things
            //var method = TestingEnum.Express;
            //var methodValue = 3;
            //var methodKey = "Express";
            //Console.WriteLine("printing the express value as a int value : " + (int)method);
            //Console.WriteLine("printing the express value as a string value : " + method.ToString());
            //Console.WriteLine("printing the express key when we have the value : " + (TestingEnum)methodValue);
            //Console.WriteLine("printing the express value when we have the key : " + Enum.Parse(typeof(TestingEnum), methodKey));



            //types
            Helloworld.TypesClass.TypeRelatedFunctionalities();


            //conditional statements
            //Helloworld.ConditionalStatements.IfRelatedFunctionalities();
            //Helloworld.ConditionalStatements.SwitchRelatedFunctionalities();

            //iterational statments
            //Helloworld.IterationalStatements.ForLoopRelatedFunctionalities();
            //Helloworld.IterationalStatements.ForEachRelatedFunctionalities();
            //Helloworld.IterationalStatements.DoWhileLoopRelatedFunctionalities();
            //Helloworld.IterationalStatements.WhileLooppRelatedFunctionalities();

            //random class related functionalities
            //Helloworld.RandomClass.RandomRelatedFunctionalities();

            //arrays related functionalities
            //Helloworld.ArrayClass.ArrayRelatedFunctionalities();

            //lists related functionalities
            //Helloworld.ListsClass.ListsRelatedFunctionalities();

            //date time related functionalities
            //Helloworld.DateTimeClass.DateTimeRelatedFunctionalities();

            //timestamp related functionalities
            //Helloworld.TimeSpanClass.TimeSpanRelatedFunctionalities();

            //strings related functionalities
            //Helloworld.Strings.FormatingFunctionalities();
            //Helloworld.Strings.OtherFunctionalities();
        }
    }
}

