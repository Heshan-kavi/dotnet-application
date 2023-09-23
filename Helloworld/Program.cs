using System;

namespace Variables
{

    class Program
    {
        static void Main(string[] args)
        {
            byte number = 23;
            float totalPrice = 23.22f;
            bool isWorking = true;

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine(number);
            Console.WriteLine(totalPrice);
            Console.WriteLine(isWorking);

            //check type conversions
            //explicit conversion
            int testingvalue = 260;
            byte testingValueTwo = (byte) testingvalue;
            Console.WriteLine("this is the value in int type :  {0}", testingvalue);
            Console.WriteLine("this is the value in byte type :  {0}", testingValueTwo);

            //implicit conversion
            int testingValueThree = 260;
            float testingValueFour = testingValueThree;
            Console.WriteLine("this is the value in int type :  {0}", testingValueThree);
            Console.WriteLine("this is the value in float type :  {0}", testingValueFour);

            //non-compatible conversion
            string testingValueFive = "12";
            float testingValueSix = Convert.ToInt16(testingValueFive);
            float testingValueSeven = int.Parse(testingValueFive);
            Console.WriteLine("this is the value in string type :  {0}", testingValueSix);
            Console.WriteLine("this is the value in int type with convert function :  {0}", testingValueSix);
            Console.WriteLine("this is the value in int type with parse function :  {0}", testingValueSeven);


            //using try and catch
            try
            {
                var stingValueEight = "1234";
                byte b = Convert.ToByte(stingValueEight);
                Console.WriteLine(b);

            }
            catch (Exception)
            {
                Console.WriteLine("there is a type conversion issue with the values !!!");
            }


            //operators
            //arithmetic operators
            var testingValueNine = 12;
            var testingValueTen = 23;

            Console.WriteLine((float)testingValueNine + (float)testingValueTen);
            Console.WriteLine(testingValueTen > testingValueNine);
            Console.WriteLine(!(testingValueTen > testingValueNine));




            //Checking non-primitve types in the C#
            Person person = new Person();
            person.FirstName = "Heshan";
            person.Secondname = "Kavinda";
            var fullName = person.Introduce();
            Console.WriteLine("this is the full name : " + fullName);
        }
    }
}

