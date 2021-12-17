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
            
            int[] oldDiagnumbers1 = obj1.diagonalArray;

            
            int[] oldDiagnumbers2 = obj2.diagonalArray;

            int newSize = obj1.Size;
            int[] newDiagNumbers = new int[obj1.diagonalArray.Length];


            if(obj1.Size == obj2.Size)
            {
                for(int i = 0; i < oldDiagnumbers1.Length; i++)
                {
                    newDiagNumbers[i] = oldDiagnumbers1[i] + oldDiagnumbers2[i];
                }
                
            }
            else if(obj1.Size < obj2.Size)
            {
                newSize = obj2.Size;

                oldDiagnumbers1 = new int[obj2.diagonalArray.Length];

                obj1.diagonalArray.CopyTo(oldDiagnumbers1, 0);

                newDiagNumbers = new int[obj2.diagonalArray.Length];

                
                for(int i = 0; i < oldDiagnumbers2.Length; i++)
                {
                    newDiagNumbers[i] = oldDiagnumbers1[i] + oldDiagnumbers2[i];
                }
            }
            else if(obj1.Size > obj2.Size)
            {
                newSize = obj1.Size;

                oldDiagnumbers2 = new int[obj1.diagonalArray.Length];

                obj2.diagonalArray.CopyTo(oldDiagnumbers2, 0);

                newDiagNumbers = new int[obj1.diagonalArray.Length];


                for (int i = 0; i < oldDiagnumbers1.Length; i++)
                {
                    newDiagNumbers[i] = oldDiagnumbers1[i] + oldDiagnumbers2[i];
                }
            }
            
            var NewMatrix = new Matrix(newSize, newDiagNumbers);

            return NewMatrix;
        }
    }
}
