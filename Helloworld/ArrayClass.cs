using System;
namespace Helloworld
{
	public class ArrayClass
	{
		public static void ArrayRelatedFunctionalities()
		{
            var numbers = new[] { 12, 32, 4, 34, 12 };

            Console.WriteLine("this is the length of the array : " + numbers.Length);                            //to get the length of the array
            Console.WriteLine("this is the index of the 4 in the array : {0}", Array.IndexOf(numbers, 4));      //to get the index of an element in the array
            Array.Clear(numbers, 1, 2);                                                                         //to clear some elements in the array
            Console.WriteLine("this is the array after clearing 32 and 4 : ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            var secondNumbers = new int[4];
            Array.Copy(numbers, secondNumbers, 4);
            Console.WriteLine("this is the copied array : ");                                                  //to copy some elements from the begining to another array
            foreach (var number in secondNumbers)
            {
                Console.WriteLine(number);
            }
            Array.Sort(secondNumbers);                                                                          //to sort an array
            Console.WriteLine("this is the sorted copied array : ");
            foreach (var number in secondNumbers)
            {
                Console.WriteLine(number);
            }
            Array.Reverse(secondNumbers);                                                                       //to reverse an array
            Console.WriteLine("this is the reversed array : ");
            foreach (var number in secondNumbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}

