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
    }
}

