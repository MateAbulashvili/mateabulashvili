using System;

namespace HW6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, len, vowel, cons;

            
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            vowel = 0;
            cons = 0;
            len = str.Length;

            for (i = 0; i < len; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    cons++;
                }
            }
            Console.Write("\n vowel count : {0}\n", vowel);
            Console.Write("\n consonant count : {0}\n\n", cons);
        }
    }
}
   

