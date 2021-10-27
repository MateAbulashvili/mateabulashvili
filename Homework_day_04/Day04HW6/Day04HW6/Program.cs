using System;

namespace Day04HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\ndivisors  are: ");

            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    if(i!=num)
                        Console.Write(i + ", "); 
                    else
                        Console.Write(i);
                }
            }
            Console.ReadLine();
        }
    }
}
