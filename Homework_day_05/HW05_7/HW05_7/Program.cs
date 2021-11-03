using System;

namespace HW05_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = CreateArray();
            Console.WriteLine("==================================");
            int[,] arr2 = CreateArray();
            int[,] sumArray = TakeAnArray(arr1, arr2);
            PrintMatrix(sumArray);
            Console.ReadLine();


        }
        static int[,] CreateArray()
        {
            Console.Write("Enter count of rows: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter count of columns: ");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==================================");
            int[,] arr = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("Enter character for index {0},{1}: ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return arr;
        }
        static int[,] TakeAnArray(int[,] arr1, int[,] arr2)// this function gets 2 arrays as a parameter and also their dimensions in order to properly print
        {
            int[,] sum = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    sum[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            Console.WriteLine("==================================");
            return sum;
        }
        static void PrintMatrix(int[,] sum)
        {
            Console.WriteLine("Here is sum of matrices");
            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {

                    if (j != sum.GetLength(1) - 1)
                    {
                        Console.Write(sum[i, j] + ", ");

                    }
                    else
                    {
                        Console.Write(sum[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}