using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1SparseMatrix
{
    class SparseMatrix: IEnumerable<int>
    {
        int Rows { get; set; }
        int Columns { get; set; }
        public Dictionary<int, int> MatrixElements { get; private set; } = new();

        public SparseMatrix(int rows, int columns)
        {
            Rows = rows > 0 ? rows : 1;
            Columns = columns > 0 ? columns : 1; ;
        }

        public int this[int row, int column]
        {
            get
            {
                int index = row * Columns + column;
                int result;
                MatrixElements.TryGetValue(index, out result);
                return result;
            }

            set
            {
                int index = row * Columns + column;
                MatrixElements[index] = value;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
