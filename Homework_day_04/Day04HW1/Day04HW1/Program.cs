using System;

namespace Day04HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = default;
            for(int i = 0; i <= 10; i++)
            {
                answer += i;
            }
            Console.WriteLine("Sum from 0 to 10 is {0}", answer);
            Console.ReadLine();
        }
    }
}
