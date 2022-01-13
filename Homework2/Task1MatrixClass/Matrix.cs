using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1MatrixClass;


namespace Task1MatrixClass
{
    public class Matrix
    {
        private int _size;
        private int[] _diagonalArray;

        public int Size { get => _size; private set => _size = value; }
        private int[] DiagonalArray { get => _diagonalArray; set => _diagonalArray = value; }

        public Matrix(params int[] diagonalNumbers)
        {
            Size = diagonalNumbers.Length;
            DiagonalArray = diagonalNumbers;

            if (diagonalNumbers == null)
            {
                Size = 0;
            }
            
        }
        public int this[int i, int j]
        {
            get
            {
                if (i == j && i >= 0 && i < DiagonalArray.Length)
                {
                    return DiagonalArray[i];
                }
                else //(i < 0 || i >= diagonalArray.Length)
                {
                    return 0; //throw exception
                }

            }
            
            set
            {
                if ((i == j) && (i >= 0) && (i < DiagonalArray.Length))
                {
                    DiagonalArray[i] = value;
                }

            }

        }

        public int Track() //Sum of the diagonal numbers in the matrix
        {
            int diagonalSum = 0;

            for (int i = 0; i < DiagonalArray.Length; i++)
            {
                diagonalSum += DiagonalArray[i];
                
            }
            return diagonalSum;
        }

        public string PrintMatrixElements()
        {
            var builder = new StringBuilder();

            foreach (int number in DiagonalArray)
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

            for (int i = 0; i < DiagonalArray.Length; i++)
            {
                if (DiagonalArray[i] != testItem.DiagonalArray[i])
                {
                    return false;
                }
            }

            return true;
        }


        public override int GetHashCode()
        {
            return DiagonalArray.GetHashCode();
        }

        public override string ToString()
        {
            return "Matrix-Size is " + Size + " Elements are " + PrintMatrixElements();
        }
    }
}
