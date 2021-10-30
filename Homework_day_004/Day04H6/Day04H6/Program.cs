using System;

namespace Day04H6
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
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    Console.Write("Enter number for index {0},{1}: ",i,j);
                    int input = Convert.ToInt32(Console.ReadLine());
                    arr[i, j] = input;
                    Console.WriteLine();          
                }
            }
            Console.WriteLine("Here is matrix view of multidimensional array");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(arr[i, j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}
