using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntMathOperation test = new IntMathOperation();
            MatrixMathOperation test2 = new MatrixMathOperation();
            VectorMathOperation test3 = new VectorMathOperation();
            
            Matrix m1 = new Matrix();
            Matrix m2 = new Matrix();

            Vector v1 = new Vector(2, 3);
            Vector v2 = new Vector(9, 5);

            Console.WriteLine("Math operation on int");
            Console.WriteLine($" 3 * 5 = {test.Multiplay(3,5)}");

            Console.WriteLine("Math operation on Matrix");
            Console.Write($" m1 * m2 = ");
            foreach (var item in test2.Multiplay(m1,m2).mymatrix)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Math operation on Vector");
            Console.WriteLine($" V1 * V2 = V3({test3.Multiplay(v1,v2).Abscissa}:{test3.Multiplay(v1, v2).Ordinate})");
        }
    }
}
