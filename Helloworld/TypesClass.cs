using System;
namespace Helloworld
{
	public class TypesClass
	{
		public static void TypeRelatedFunctionalities()
		{
            var numberOne = 12;
            var numberTwo = numberOne;
            numberTwo++;
            Console.WriteLine("This is the number one : {0} and this is number two : {1}", numberOne, numberTwo);           //value type

            var arrayOne = new int[3] { 1, 2, 3 };
            var arrayTwo = arrayOne;
            arrayTwo[0] = 55;
            Console.WriteLine("This is the number one : {0} and this is number two : {1}", arrayOne[0], arrayTwo[0]);       //reference type
        }

        public static void BasicTypeConversions()
        {
            //explicit conversion
            int testingvalue = 260;
            byte testingValueTwo = (byte)testingvalue;
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
        }
    }
}

