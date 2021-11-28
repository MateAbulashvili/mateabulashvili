using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class MatrixMathOperation : IMathOperation<Matrix>
    {
        public Matrix Multiplay(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int temp = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        temp += m1.mymatrix[i, k] * m2.mymatrix[k, j];
                    }
                    result.mymatrix[i, j] = temp;
                }
            }

            return result;
        }

        public Matrix Subtract(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result.mymatrix[i, j] = m1.mymatrix[i, j] - m2.mymatrix[i, j];
                }
            }

            return result;
        }

        public Matrix Sum(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result.mymatrix[i, j] = m1.mymatrix[i, j] + m2.mymatrix[i, j];
                }
            }

            return result;
        }
    }
}