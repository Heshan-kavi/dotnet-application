using System;
namespace Helloworld
{
	public class ListsClass
	{
		public static void ListsRelatedFunctionalities()
		{
            var numberList = new List<int>() { 1, 2, 8 };                                                                   //to initialize the list
            numberList.Add(1);                                                                                              //add a single value to the list
            numberList.AddRange(new int[] { 5, 6, 7 });                                                                     //add range of values to the list
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("This is the lenght of the list : " + numberList.Count);                                      //to get the length of the list
            Console.WriteLine("This is the index of the 1 from the begining from the list : " + numberList.IndexOf(1));     //to get the index of a value in the list from the begining
            Console.WriteLine("This is the index of the 1 from the end from the list : " + numberList.LastIndexOf(1));      //to get the index of a value in the list from the end

            for (int i = 0; i < numberList.Count; i++)
            {
                numberList.Remove(1);                                                                                       //to remove all the 1 values. in here cannot use foreach because it generates an error
            }
            Console.WriteLine("this is the count of the list after removing the 1 values : ");
            Console.WriteLine(numberList.Count);
            Console.WriteLine("this is the list after removing the 1 values : ");
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }
            numberList.Clear();                                                                                             //to clear the whole list
            Console.WriteLine("this is the count of the list after clearing : ");
            Console.WriteLine(numberList.Count);

        }
    }
}

