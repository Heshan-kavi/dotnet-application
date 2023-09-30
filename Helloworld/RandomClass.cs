using System;
namespace Helloworld
{
	public class RandomClass
	{
		public static void RandomRelatedFunctionalities()
		{
            Random random = new Random();
            int passwordLength = 10;
            char[] buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(1, 26));
            }
            var password = new string(buffer);                      //in here we create a new string using an array of characters
            Console.WriteLine(password);
        }
	}
}

