using System;

namespace HW05_1

{
    class Program
    {
        static void Main(string[] args)
        {
            // this is the first way of solving this(Main Method)
            #region
            //int[] arr = { 1, 3, 4, 15, 13, 23, 98 };
            //int input = -1;
            //while(input>=arr.Length || input < 0)
            //{
            //    Console.Write("Enter index number: ");
            //    input = Convert.ToInt32(Console.ReadLine());
            //}
            #endregion           //ReturnNumber(arr, input);
            int[] arr = { 1, 3, 4, 15, 13, 23, 98 };
            int input = -1;
            while (input >= arr.Length || input < 0) // Checking in terms of incorrect input
            {
                Console.Write("Enter index number: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Number at index {0} in the array is {1}", input, ReturnNumber2(arr, input));
            Console.ReadLine();
        }
        //this is the first way of solving this(Helper Method)
        #region
        //static void ReturnNumber(int [] arr, int index)
        //{
        //    Console.WriteLine("Number at index {0} in the array is {1}", index, arr[index]);
        #endregion   //}
        static int ReturnNumber2(int[] arr, int index)
        {
            return arr[index];
        }
    }
}