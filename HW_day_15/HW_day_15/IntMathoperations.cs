using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class IntMathOperation : IMathOperation<int>
    {

        public int Multiplay(int v1, int v2)
        {
            return v1 * v2;
        }

        public int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        public int Sum(int v1, int v2)
        {
            return v1 + v2;
        }
    }
}
