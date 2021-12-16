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
            int newSize1 = obj1.Size;
            int[] newDiagNumbers1 = obj1.diagonalArray;

            int newSize2 = obj2.Size;
            int[] newDiagNumbers2 = obj2.diagonalArray;

            if(obj1.Size == obj2.Size)
            {
                return obj2;
            }

            
            //var MewMatrix = new Matrix(int newSize, int[] newDiagNumbers); 
            
            throw new NotImplementedException();
        }
    }
}
