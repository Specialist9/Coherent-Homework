using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1GenericDiagonalMatrix
{
    static class MatrixAddExtension
    {
        public static Matrix<T> MatrixAdd<T>(this Matrix<T> obj1, Matrix<T> obj2, Add2GenTypes<T> del)
        {
            //var testDelegate = new Add2GenTypes<T>(AddGenericTypes);
            var testDelegate = del;


            int newSize = obj1.Size > obj2.Size ? obj1.Size : obj2.Size;
            T[] newElements = new T[newSize];

            for (int i = 0; i < newSize; i++)
            {
                newElements[i] = testDelegate.Invoke(obj1[i, i], obj2[i, i]);
            }

            return new Matrix<T>(newSize);
        }


        public delegate T Add2GenTypes<T>(T type1, T type2);

        public static T AddGenericTypes<T>(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

    }
}
