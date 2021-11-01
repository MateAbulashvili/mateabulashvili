using System;

namespace HW05_6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = CreateArray();
            char symbol = 'g';
            int count = FindSymbol(arr, symbol);
            PrintOccurence(count, symbol);

        }
        static char[] CreateArray()
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            char[] arr = new char[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter character for index {0}: ", i);
                arr[i] = Convert.ToChar(Console.ReadLine());
            }
            return arr;
        }
        static int FindSymbol(char[] arr, char symbol)
        {
            int count = 0; // creating count variable in order to track the occurance
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == symbol)
                {
                    count++; // if we find the symbol we are incrementing the count variable
                }
            }
            if (count > 0) // we are checking if the count is more than 0 hence we have found the item in the array and we are returning the count of it
                return count;
            else return 0;
        }
        static void PrintOccurence(int count, char symbol)
        {
            if (count > 0)
                Console.WriteLine("'{0}' shegvxvda {1}-jer", symbol, count);
            else
                Console.WriteLine("'{0}' ar shegvxvda arcertxel", symbol);
        }
    }
}
