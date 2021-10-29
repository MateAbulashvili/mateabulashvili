using System;  
public class Exercise1
{
    public static void Main()
    {
        int[] arr = new int[5];
        int i;
        Console.Write("Enter array size-");

        
        for (i = 0; i < 5; i++)
        {
            Console.Write("element - {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Here is your array! ");

        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("{0}  ", arr[i]);
        }
        Console.Write("\n");
    }
}