using System;

namespace Day04H8
{
    class Program
    {
        static void Main(string[] args)
        {

            int row = 8;
            int column = 8;
            Console.WriteLine();
            int[,] arr = new int[row, column];
            for (int i = 0; i <row; i++)
            {
                for (int j = 0; j <column; j++)
                {

                    if (j <= i)
                    {
                        arr[i, j] = 0;
                        Console.Write(arr[i, j] + " ");
                    }
                    else
                    {
                        arr[i, j] = 1;
                        Console.Write(arr[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
           
            for(int i=row-1;i>=0; i--)
            {
                for(int j = 0; j < column; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
