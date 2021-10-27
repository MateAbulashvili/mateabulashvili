using System;

namespace Day04HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Please Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= number; i += 2)
            {
                sum += i;
            }
            Console.WriteLine("Sum of odd number from 1 to {0} is {1}", number, sum);
            Console.ReadLine();
        }
    }
}
