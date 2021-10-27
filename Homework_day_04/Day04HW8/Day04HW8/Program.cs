using System;

namespace Day04HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Please Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("decimal {0} in binary is ", number);
            int exact = 1;
            int store = 0;
            for (int i = number; i > 0; i/=2)
            {
                store = store + (number % 2) * exact;
                exact *= 10;
                number /= 2;
            }
            Console.Write(store);
            Console.ReadLine();
        }
    }
}
