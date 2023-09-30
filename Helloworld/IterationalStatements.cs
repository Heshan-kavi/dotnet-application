using System;
using System.Xml.Linq;

namespace Helloworld
{
	public class IterationalStatements
	{
		public static void ForLoopRelatedFunctionalities()
		{
            int[] numbers = new int[] { 1, 2, 3 };

            //for loop
            Console.WriteLine("this is the for loop result: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void ForEachRelatedFunctionalities()
        {
            //foreach loop
            int[] numbers = new int[] { 1, 2, 3 };
            string name = "Heshan Kavinda";
            Console.WriteLine("this is the foreach loop result: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            foreach (var character in name)
            {
                if (character == ' ')
                {
                    continue;
                }
                Console.WriteLine(character);
            }
        }

        public static void WhileLooppRelatedFunctionalities()
        {
            //while loop
            int[] numbers = new int[] { 1, 2, 3 };
            Console.WriteLine("this is the while loop result: ");
            int j = 0;
            while (j < numbers.Length)
            {
                Console.WriteLine(numbers[j]);
                j++;
            }
        }

        public static void DoWhileLoopRelatedFunctionalities()
        {
            //do-while loop
            int[] numbers = new int[] { 1, 2, 3 };
            Console.WriteLine("this is the do-while loop result: ");
            int l = 0;
            do
            {
                Console.WriteLine(l);
                l++;
            }
            while (l < numbers.Length);
        }
    }
}

