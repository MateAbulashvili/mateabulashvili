using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{

    interface IMathOperation<T>
    {
        public T Sum(T v1, T v2);
        public T Subtract(T v1, T v2);
        public T Multiplay(T v1, T v2);
    }
}
