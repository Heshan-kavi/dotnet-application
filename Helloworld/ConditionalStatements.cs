using System;
namespace Helloworld
{
	public class ConditionalStatements
	{
		public static void IfRelatedFunctionalities()
		{
            //if statments
            int age = 12;

            if (age < 10)
            {
                Console.WriteLine("You cannot access the page;");
            }
            else if (age >= 10 && age <= 20)
            {
                Console.WriteLine("you can access the web with limited access");
            }
            else
            {
                Console.WriteLine("you can access the web with unlimited access");
            }

        }

        public static void SwitchRelatedFunctionalities()
        {
            //switch statements
            int level = 2;
            switch (level)
            {
                case 1:
                case 2:
                    Console.WriteLine("you have access only for the first two levels in the building");
                    break;

                case 3:
                    Console.WriteLine("you have access only for the level three");
                    break;

                default:
                    Console.WriteLine("you do not have any access to any of levels");
                    break;
            }
        }
    }
}

