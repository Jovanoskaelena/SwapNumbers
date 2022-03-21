using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne, numberTwo, third;
            Console.WriteLine("Enter the first Number:");
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number:");
            numberTwo = int.Parse(Console.ReadLine());
            third = numberOne;
            numberOne = numberTwo;
            numberTwo = third;
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + numberOne);
            Console.WriteLine("Second Number : " + numberTwo);
            Console.Read();
        }
    }
}
