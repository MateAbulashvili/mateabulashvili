using System;

namespace Day09H3
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock c1 = new Clock();
            Console.Write("Enter hours: ");
            c1.Hour = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter minutes: ");
            c1.Minute = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter seconds: ");
            c1.Second = Convert.ToSByte(Console.ReadLine());
            c1.GetCurrentTime();
            c1.AddSecond();
            c1.AddSecond();
            c1.AddSecond();
            c1.AddSecond();
            c1.GetCurrentTime();
            c1.AddSecond();
            c1.AddSecond();
            c1.AddSecond();
            c1.AddMinute();
            c1.GetCurrentTime();

           



        }
    }
}
