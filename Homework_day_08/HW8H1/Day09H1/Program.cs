using System;

namespace Day09H1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Cat object...");
            Cat cat = new Cat();
            Console.Write("Enter Name: ");
            cat.Name = Console.ReadLine();
            Console.Write("Enter breed: ");
            cat.Breed = Console.ReadLine();
            Console.Write("Enter age: ");
            cat.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter sex: ");
            string sex = Console.ReadLine();
            if (sex == "male")
                cat.Gender = true;
            else if (sex == "female")
                cat.Gender = false;
            Console.WriteLine("Cat object created.");
            Console.Write("Enter food weight in grams: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} started eating.", cat.Name);
            cat.Eat(amount);
            Console.WriteLine("{0} finished eating.",cat.Name);
            Console.Write("Enter meowing count: ");
            cat.Meow(Convert.ToInt32(Console.ReadLine()));

        }
    }
}
