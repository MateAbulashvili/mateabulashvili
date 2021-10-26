using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 != 0)
            {
                if (num != 0)
                {
                    Console.WriteLine("number {0} is odd", num);
                }
            }
            else
                Console.WriteLine("number {0} is even", num);


            Console.ReadLine();



        }
    }
}
