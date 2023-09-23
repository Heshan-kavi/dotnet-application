using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 23;
            float totalPrice = 23.22f;
            bool isWorking = true;

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine(number);
            Console.WriteLine(totalPrice);
            Console.WriteLine(isWorking);
        }
    }
}

