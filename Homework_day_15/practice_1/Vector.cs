using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class Vector
    {
        public Vector()
        {

        }
        public Vector(int x, int y)
        {
            Abscissa = x;
            Ordinate = y;
        }
        public int Abscissa { get; set; }
        public int Ordinate { get; set; }
    }
}
