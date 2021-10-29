using System;

namespace Day04H7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array row size: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter array column size: ");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] arr = new int[row, column];
            int[,] arr2 = new int[row, column];
            Console.WriteLine("Fill first matrix");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("Enter number for index {0},{1}: ", i, j);
                    int input = Convert.ToInt32(Console.ReadLine());
                    arr[i, j] = input;
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Fill second matrix");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("Enter number for index {0},{1}: ", i, j);
                    int input = Convert.ToInt32(Console.ReadLine());
                    arr2[i, j] = input;
                    Console.WriteLine();
                }
                
            }    
            Console.WriteLine("Here is sum of two matrices");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (j == column - 1)
                    {
                        Console.Write((arr2[i, j] + arr[i, j]));
                    }
                    else
                    {
                        Console.Write((arr2[i, j] + arr[i, j]) + ", ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
