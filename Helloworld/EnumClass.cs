using System;
namespace Helloworld
{
	public class EnumClass
	{

        public enum TestingEnum
        {
            RegularAirMail = 1,
            RegiseredAirMail = 2,
            Express = 3
        }

        public static void EnumRelatedFunctionalities()
		{
            var method = TestingEnum.Express;
            var methodValue = 3;
            var methodKey = "Express";
            Console.WriteLine("printing the express value as a int value : " + (int)method);
            Console.WriteLine("printing the express value as a string value : " + method.ToString());
            Console.WriteLine("printing the express key when we have the value : " + (TestingEnum)methodValue);
            Console.WriteLine("printing the express value when we have the key : " + Enum.Parse(typeof(TestingEnum), methodKey));
        }
    }
}

