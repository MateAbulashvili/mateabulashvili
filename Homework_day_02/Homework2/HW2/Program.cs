using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("This is not a triangle");
            }
            else
            {
                Console.WriteLine("This is not a triangle");

            }

        }
    }
}
