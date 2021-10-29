using System;
public class Exercise2
{
    public static void Main()
    {
        int i, n;
        int[] a = new int[100];

        
        

        Console.Write("ENTER THE SIZE OF ARRAY:");
        n = Convert.ToInt32(Console.ReadLine());
 
       for (i = 0; i < n; i++)
        {

            Console.Write("Enter number for index - {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        
        }


        
        Console.WriteLine("Here is your array in reverse order");
        
        for (i = n - 1; i >= 0; i--)
        {
        
            Console.WriteLine("{0} ", a[i]);
        
        }
        
        Console.WriteLine("\n\n");
    }
}