using System;
using System.Collections.Generic;
using System.Text;

namespace Day09H2
{
    class Triangle
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        private double TriangleArea = 0;
        private double TrianglePerimeter = 0;
        public double Perimeter
        {
            get
            {
                return TrianglePerimeter;
            }
            set
            {
                TrianglePerimeter = value;
            }
        }
        public double Area
        {
            get
            {
                return TriangleArea;
            }
            set
            {
                TriangleArea = value;
            }
        }

        public void CalculatePerimeter(double a, double b, double c)
        {
            Perimeter = a + b + c;
        }
        public void CalculateArea(double a, double b, double c)
        {
            if(c*c== (a * a) + (b * b))
            {
                Area = (a * b) / 2;
            }
            else
            {
                double s = (a + b + c) / 2;
                Area = Math.Sqrt(s*(s - a) * (s - b) * (s - c));
            }
        }
        public bool ValidateTriangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                return false;
            else
            {
                return true;
            }
        }
    }
}
