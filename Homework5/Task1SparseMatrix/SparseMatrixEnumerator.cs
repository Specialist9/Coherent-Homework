using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1SparseMatrix
{
    class SparseMatrixEnumerator : IEnumerator
    {
        
        Dictionary<int, int> MatrixElements;
        int MatrixSize;
        int position = -1;

        public SparseMatrixEnumerator(int matrixSize, Dictionary<int, int> matrixElements)
        {
            MatrixElements = matrixElements;
            MatrixSize = matrixSize;
        }
        public object Current
        {
            get
            {
                int cell;
                if(position == -1 || position >= MatrixSize)
                        throw new ArgumentException();
                cell = MatrixElements.TryGetValue(position, out cell) ? cell : default;
                return cell;
            }
        }

        public bool MoveNext()
        {
            if (position < MatrixSize - 1)
            {
                position++;
                return true;
            }
            else return false;

        }

        public void Reset()
        {
            position = -1;
        }
        
    }
}
