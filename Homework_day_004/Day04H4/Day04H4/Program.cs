using System;

namespace Homework_day_004_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter number for index {0}: ", i);
                int j = Convert.ToInt32(Console.ReadLine());
                arr[i] = j;
                Console.WriteLine();
            }

            int multiple = arr[0];
            for (int i = 1; i < size; i++)
            {
                multiple *= arr[i];
            }
            Console.WriteLine("Product of array elements is {0}",multiple );
        }
    }
}
