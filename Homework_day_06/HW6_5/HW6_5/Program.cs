using System;

namespace HW6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int alp, digit, othr, i, l;
            alp = digit = othr = i = 0;
          
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            l = str.Length;

            /* Checks each character of string*/

            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alp++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    othr++;
                }

                i++;
            }

            Console.Write("Letters : {0}\n", alp);
            Console.Write("numbers : {0}\n", digit);
            Console.Write("Others : {0}\n\n", othr);
        }
    }
}
