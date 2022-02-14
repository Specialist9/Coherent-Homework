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
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public Dictionary<int, int> MatrixElements { get; private set; } = new();

        public SparseMatrix(int rows, int columns)
        {
            Rows = rows > 0 ? rows : 1;
            Columns = columns > 0 ? columns : 1;
        }

        public int this[int row, int column]
        {
            get
            {
                int index = row * Columns + column;
                int result = MatrixElements.TryGetValue(index, out result) ? result : default;
                return result;
            }

            set
            {
                int index = row * Columns + column;
                if(value != 0) MatrixElements[index] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder tempString = new();

            foreach(var cell in this)
            {
                tempString.Append($" {cell}, ");
            }
            
            return tempString.ToString();
        }

        public int GetCount(int x)
        {
            int count = 0;

            foreach (var cell in this)
            {
                int cellValue = cell;
                
                if(cellValue == x)
                {
                    count++;
                }
            }
            return count;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Columns; j++)
                {
                    yield return this[i, j];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return MatrixElements.GetEnumerator();
        }

        public IEnumerable<(int, int, int)> GetNoZeroElements()
        {
            List<(int, int, int)> tempList = new();

            foreach (var cell in MatrixElements)
            {
                tempList.Add((cell.Key / Columns, cell.Key % Columns, cell.Value));
            }
            var orderedList = tempList.OrderBy(t => t.Item2).ThenBy(t => t.Item1);
            return orderedList;
            
        }

    }
}
