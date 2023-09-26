using System;
using Helloworld.Math;

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
            //var numberOne = 12;
            //var numberTwo = numberOne;
            //numberTwo++;
            //Console.WriteLine("This is the number one : {0} and this is number two : {1}", numberOne, numberTwo);           //value type

            //var arrayOne = new int[3]{ 1, 2, 3};
            //var arrayTwo = arrayOne;
            //arrayTwo[0] = 55;
            //Console.WriteLine("This is the number one : {0} and this is number two : {1}", arrayOne[0], arrayTwo[0]);       //reference type


            //conditional statements
            //if statments
            //int age = 12;
            //int level = 2;

            //if(age < 10)
            //{
            //    Console.WriteLine("You cannot access the page;");
            //}else if(age >= 10 && age <= 20)
            //{
            //    Console.WriteLine("you can access the web with limited access");
            //}
            //else
            //{
            //    Console.WriteLine("you can access the web with unlimited access");
            //}


            ////switch statements
            //switch (level)
            //{
            //    case 1:
            //    case 2:
            //        Console.WriteLine("you have access only for the first two levels in the building");
            //        break;

            //    case 3:
            //        Console.WriteLine("you have access only for the level three");
            //        break;

            //    default:
            //        Console.WriteLine("you do not have any access to any of levels");
            //        break;
            //}




            //iterational statments
            int[] numbers = new int[] { 1, 2, 3 };
            string name = "Heshan Kavinda";

            //for loop
            Console.WriteLine("this is the for loop result: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach loop
            //Console.WriteLine("this is the foreach loop result: ");
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            foreach(var character in name)
            {
                if(character == ' ')
                {
                    continue;
                }
                Console.WriteLine(character);
            }

            //while loop
            //Console.WriteLine("this is the while loop result: ");
            //int j = 0;
            //while(j < numbers.Length)
            //{
            //    Console.WriteLine(numbers[j]);
            //    j++;
            //}

            //do-while loop
            //Console.WriteLine("this is the do-while loop result: ");
            //int l = 0;
            //do
            //{
            //    Console.WriteLine(l);
            //    l++;
            //}
            //while (l < numbers.Length);
        }
    }
}

