using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1MatrixClass
{
    static class MatrixSumMethod
    {
        public static Matrix MatrixAdd(this Matrix obj1, Matrix obj2)
        {
            int newSize = obj1.Size > obj2.Size ? obj1.Size : obj2.Size;
            int[] newElements = new int[newSize];

            for (int i = 0; i < newSize; i++)
            {
                newElements[i] = obj1[i, i] + obj2[i, i];   //We do not worry about OutOfRangException, because our indexers return 0 when i is out of size. 
            }
            
            return new Matrix(newSize, newElements);
        }
    }
}
