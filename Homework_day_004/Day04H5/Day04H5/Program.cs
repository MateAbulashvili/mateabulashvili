using System;

namespace Homework_day_004_05
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
            bool isEqual = false;
            Console.WriteLine("Unique elements of array are ");
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j])
                        {
                            isEqual = false;
                            break;
                        }
                        else
                        {
                            isEqual = true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                if (isEqual == true)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            
        }
    }
}
