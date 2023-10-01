using System;
namespace Helloworld
{
	public class OperatorsClass
	{
		public static void OperatorsRelatedFunctionalities()
		{
            //arithmetic operators
            var testingValueNine = 12;
            var testingValueTen = 23;

            Console.WriteLine((float)testingValueNine + (float)testingValueTen);
            Console.WriteLine(testingValueTen > testingValueNine);
            Console.WriteLine(!(testingValueTen > testingValueNine));
        }
    }
}

