using System;

namespace HW05_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic average of array is {0}", ReturnAverage(CreateArray()));
            Console.ReadLine();
        }
        static int[] CreateArray()
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter integer for index {0}: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static double ReturnAverage(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
    }
}
