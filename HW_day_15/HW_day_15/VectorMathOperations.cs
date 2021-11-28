using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class VectorMathOperation : IMathOperation<Vector>
    {
        public Vector Multiplay(Vector v1, Vector v2)
        {
            Vector result = new Vector();
            result.Abscissa = v1.Abscissa * v2.Abscissa;
            result.Ordinate = v1.Ordinate * v2.Ordinate;
            return result;
        }

        public Vector Subtract(Vector v1, Vector v2)
        {
            Vector result = new Vector();
            result.Abscissa = v1.Abscissa - v2.Abscissa;
            result.Ordinate = v1.Ordinate - v2.Ordinate;
            return result;
        }

        public Vector Sum(Vector v1, Vector v2)
        {
            Vector result = new Vector();
            result.Abscissa = v1.Abscissa + v2.Abscissa;
            result.Ordinate = v1.Ordinate + v2.Ordinate;
            return result;
        }
    }
}

