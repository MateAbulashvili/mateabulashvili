using System;

namespace Day04H9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = 8;
            int[][] arr = new int[numb][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[numb];
                for(int j = 0; j < numb; j++)
                {
                    if (j<=i)
                    {
                        arr[i][j] = 0;
                        Console.Write(arr[i][j] + " ");    
                    }
                    else
                    {
                        arr[i][j] = 1;
                        Console.Write(arr[i][j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = numb - 1; i >= 0; i--)
            {
                for (int j = 0; j < numb; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
