using System;

namespace Day04HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a number: ");
            
            int inp = Convert.ToInt32(Console.ReadLine());
            
            int result = default;
            
            for(int i = 0; i <= inp; i++)
            {
                result += i; 
            }
            
            Console.WriteLine("Sum from 1 to {0} is {1}", inp, result);
            
            Console.ReadLine();
        }
    }
}
