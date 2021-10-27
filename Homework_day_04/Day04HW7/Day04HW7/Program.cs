using System;

namespace Day04HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Please Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result =0 ;
            int former = 0;
            int temp = 1;
                for(int i = 2; i <= number; i++)
            {
                result = former + temp;
                if (i != number)
                {
                    Console.Write(result + ", ");
                }
                else
                {
                    Console.Write(result);
                }
                former = temp;
                temp = result;

            }
           
          
            Console.ReadLine();
        }
    }
}
