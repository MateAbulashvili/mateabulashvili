using System;

namespace HW05_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = CreateArray();
            Console.Write("Please enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (Factorial(arr, number) == -1)
            {
                Console.WriteLine("Number {0} was not found in the given array", number);
            }
            else
            {
                Console.WriteLine("Factorial of {0} is {1}", number, Factorial(arr, number));
            }

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
        static int Factorial(int[] arr, int number)
        {
            bool Exist = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    Exist = true;
                    break;
                }

            }
            int factorial = 1;
            if (Exist)
            {
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
            }
            else
            {
                return -1;
            }
            return factorial;
        }
    }
}
