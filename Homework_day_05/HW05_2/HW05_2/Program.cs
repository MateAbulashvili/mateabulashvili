using System;

namespace HW05_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 123, 15, 13, 23, 98 };
            int input = -1;// I am assigning input to -1 because we need to satisfy the while loop condition
            while (input >= arr.Length || input < 0) // Checking in terms of incorrect input
            {
                Console.Write("Enter index number: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The sum of the digits of a number at index {0} is {1}", input, ReturnNumber2(arr, input));
            Console.ReadLine();
        }
        static int ReturnNumber2(int[] arr, int index)
        {
            int Element = arr[index];
            int TheSumOfElements = 0;
            while (Element > 0)
            {
                int remainder = Element % 10;
                TheSumOfElements += remainder;
                Element = Element / 10;
            }
            return TheSumOfElements;
        }
    }
}
