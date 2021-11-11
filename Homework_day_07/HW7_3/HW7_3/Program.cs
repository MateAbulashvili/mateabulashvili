using System;

namespace HW7_3
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.Write(" Input any number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n The number {0} contains number of digits : {1} ", num, getDigits(num, 0));
            Console.ReadLine();
        }

        public static int getDigits(int n1, int digits)
        {
            if (n1 == 0)
                return digits;

            return getDigits(n1 / 10, ++digits);
        }
    }
}
