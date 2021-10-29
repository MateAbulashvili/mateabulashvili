using System;
public class Homework_day_004_3
{
    public static void Main()
    {
        int[] a = new int[100];
        int i, n, sum = 0;

        Console.Write("Enter size of array :");
        n = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < n; i++)
        {
            Console.Write("Enter number of index - {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        Array.ForEach(array, i => sum += i);

        Console.WriteLine(sum);

    }
}