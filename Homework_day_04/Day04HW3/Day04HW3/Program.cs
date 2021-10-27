   using System;

namespace Day04HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Please Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            double Cube = 0;
            for(int i = 1; i <= number; i++)
            {
                Cube = i*i*i;
                Console.WriteLine("{0} cubed is {1}", i, Cube);
            }
            Console.ReadLine();
        }
    }
}
