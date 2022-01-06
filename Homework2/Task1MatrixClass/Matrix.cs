using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1MatrixClass
{
    public class Matrix
    {
        public int Size { get; }
        public int[] diagonalArray;

        public Matrix(int matrixSize, params int[] diagonalNumbers)
        {
            Size = matrixSize;
            diagonalArray = diagonalNumbers;

            if ((matrixSize != diagonalNumbers.Length) || (diagonalNumbers == null))
            {
                Size = 0;
            }
            
        }
        public int this[int i, int j]
        {
            get
            {
                if ((i == j) && (i >= 0) && (i < diagonalArray.Length))
                {
                    return diagonalArray[i];
                }
                else //(i < 0 || i >= diagonalArray.Length)
                {
                    return 0; //throw exception
                }

            }
            
            set
            {
                if ((i == j) && (i >= 0) && (i < diagonalArray.Length))
                {
                    diagonalArray[i] = value;
                }
                else
                {
                    return;
                }
            }

        }

        public int Track() //Sum of the diagonal numbers in the matrix
        {
            int diagonalSum = 0;

            for (int i = 0; i < diagonalArray.Length; i++)
            {
                diagonalSum += diagonalArray[i];
                
            }
            return diagonalSum;
        }

        public string PrintMatrixElements()
        {
            var builder = new StringBuilder();

            foreach (int number in diagonalArray)
            {
                builder.Append(number);
            }

            return builder.ToString();
        }

        public override bool Equals(object obj)
        {
            var testItem = obj as Matrix;

            if (obj == null || GetType() != obj.GetType() || Size != testItem.Size)
            {
                return false;
            }

            for (int i = 0; i < diagonalArray.Length; i++)
            {
                if (diagonalArray[i] != testItem.diagonalArray[i])
                {
                    return false;
                }
            }

            return true;
        }


        public override int GetHashCode()
        {
            return diagonalArray.GetHashCode();
        }

        public override string ToString()
        {
            return "Matrix-Size is " + Size + " Elements are " + PrintMatrixElements();
        }
    }
}
