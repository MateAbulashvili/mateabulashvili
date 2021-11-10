using System;

namespace Day09H2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.Write("Enter side 1: ");
            triangle.a = double.Parse(Console.ReadLine());
            Console.Write("Enter side 2: ");
            triangle.b = double.Parse(Console.ReadLine());
            Console.Write("Enter side 3: ");
            triangle.c = double.Parse(Console.ReadLine());
            if(triangle.ValidateTriangle(triangle.a,triangle.b, triangle.c) == true)
            {
                triangle.CalculatePerimeter(triangle.a, triangle.b, triangle.c);
                triangle.CalculateArea(triangle.a, triangle.b, triangle.c);
                Console.WriteLine("Perimeter of the triangle is: {0}", triangle.Perimeter);
                Console.WriteLine("Area of the triangle is: {0}", triangle.Area);
            }
            else
            {
                Console.WriteLine("It is not valid triangle");
            }




        }
    }
}
