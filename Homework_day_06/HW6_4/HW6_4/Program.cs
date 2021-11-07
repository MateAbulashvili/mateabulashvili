using System;

namespace HW6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, wrd, l;

            
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            l = 0;
            wrd = 1;

           
            while (l <= str.Length - 1)
            {
              
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }

                l++;
            }

            Console.Write("Total number of words in the string is : {0}\n", wrd);
        }
    }
}
