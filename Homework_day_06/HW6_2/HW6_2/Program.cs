using System;

namespace HW6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int l = 0;

            
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            l = str.Length - 1;
            Console.Write("The characters of the string in reverse are : \n");
            while (l >= 0)
            {
                Console.Write("{0} ", str[l]);
                l--;
            }
            
        }
    }
}
