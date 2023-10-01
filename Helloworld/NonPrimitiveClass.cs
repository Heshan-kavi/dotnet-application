using System;
using Variables;
using Helloworld.Math;
namespace Helloworld
{
	public class NonPrimitiveClass
	{
		public static void NonPrmitiveTypeRelatedFunctionalities()
		{
            Person person = new Person();
            person.FirstName = "Heshan";
            person.Secondname = "Kavinda";
            person.age = 23;
            person.address = "Meegoda";
            var fullName = person.Introduce();
            Console.WriteLine("this is the full name : " + fullName);

            //testing a class which is located in a different field
            Calculator calculator = new Calculator();
        Console.WriteLine("This is the resulf from the cal : " + calculator.AddNumbers(12, 23));
        }
    }
}

