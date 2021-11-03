using System;

namespace HW05_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            int max;
            int[] arr = CreateArray();
            ReturnMaxMin(arr, out min, out max);
            Console.WriteLine("The minimum number in the array is {0}", min);
            Console.WriteLine("The maximum number in the array is {0}", max);
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
        static void ReturnMaxMin(int[] arr, out int Min, out int Max) // here I am using out in order to return multiple values from function
        {
            Min = arr[0];
            Max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (Min > arr[i])
                {
                    Min = arr[i];
                }
                if (Max < arr[i])
                {
                    Max = arr[i];
                }

            }
        }
    }
}
