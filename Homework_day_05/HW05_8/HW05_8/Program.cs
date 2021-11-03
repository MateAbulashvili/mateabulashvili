using System;

namespace HW05_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = InputNumber();
            Calculate(userInput);
            Console.ReadLine();

        }
        static int InputNumber()
        {
            int input = -1;
            while (input <= 0)
            {
                Console.Write("Enter a positive number: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            return input;
        }
        static void Calculate(int input)
        {
            Console.Write("{0} = ", input);
            int[] arr = new int[input.ToString().Length];// we are using the lengt of digits in terms of array size
            int counter = 0;
            while (input > 0)
            {
                arr[counter] = input % 10;
                input = input / 10;
                counter++;
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                    Console.Write("{0} * 10^{1} + ", arr[i], i);
                else
                    Console.Write("{0} * 10^{1}", arr[i], i);
            }
        }
    }
}