using System;

namespace Day04HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number of rows  to be printed: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <num; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if (((i + j) % 2) == 0)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }
    }
}
