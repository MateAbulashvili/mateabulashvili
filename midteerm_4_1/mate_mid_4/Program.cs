using System;
using System.Threading.Tasks;

public class Some
{
    public static void Main()
    {
        Console.WriteLine("Please enter the amount of Players: ");
        int players = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please Enter the set of numbers ");
        int[] numbers = new int[3];
        Task[] tasks = new Task[players];
        for (int i = 0; i < numbers.Length; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            numbers[i] = number;
        }

        for (int i = 0; i < tasks.Length; i++)
        {
            tasks[i] = new Task(() =>
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Number {1} is equal to {2}", i + 1, j + 1, RandomGenerator().Result);
                }

            });
        }

        Parallel.ForEach<Task>(tasks, (t) => { t.Start(); });
        Task.WaitAll(tasks);



    }

    public static Task<int> RandomGenerator()
    {
        return Task.FromResult(new Random().Next(0, 7));
    }
}

