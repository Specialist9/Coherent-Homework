using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1GenericDiagonalMatrix
{
    static class MatrixAddExtension
    {
        public static DiagonalMatrix<T> MatrixAdd<T>(this DiagonalMatrix<T> obj1, DiagonalMatrix<T> obj2, Func<T,T,T> del)
        {
            var testDelegate = del;


            int newSize = obj1.Size > obj2.Size ? obj1.Size : obj2.Size;
            T[] newElements = new T[newSize];

            for (int i = 0; i < newSize; i++)
            {
                newElements[i] = testDelegate.Invoke(obj1[i, i], obj2[i, i]);
            }

            return new DiagonalMatrix<T>(newSize, newElements);
        }


        public delegate T Add2GenTypes<T>(T type1, T type2);

    }
}
