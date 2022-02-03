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
        public int Size { get; }
        public Dictionary<int, int> MatrixElements { get; private set; } = new();

        public SparseMatrix(int rows, int columns)
        {
            Rows = rows > 0 ? rows : 1;
            Columns = columns > 0 ? columns : 1;
            Size = Rows * Columns;
        }

        public int this[int row, int column]
        {
            get
            {
                int index = row * Columns + column;
                int result;
                MatrixElements.TryGetValue(index, out result); // + default option
                return result;
            }

            set
            {
                int index = row * Columns + column;
                MatrixElements[index] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder tempString = new();

            for(int i = 0; i < Size; i++)
            {
                int cellValue = MatrixElements.TryGetValue(i, out cellValue) ? cellValue : default;
                tempString.Append($" {cellValue},");
            }
            
            return tempString.ToString();
        }

        public int GetCount(int x)
        {
            int count = 0;

            for (int i = 0; i < Size; i++) //foreach + IEnumerable
            {
                int cellValue;
                MatrixElements.TryGetValue(i, out cellValue);
                
                if(cellValue == x)
                {
                    count++;
                }
            }
            return count;
        }

        public IEnumerable<(int, int, int)> GetNoZeroElements() // use indexer + IEnumerable
        {
            List<(int, int, int)> tempList = new();
            foreach(var cell in MatrixElements)
            {
                int row = cell.Key / Columns;
                int column = cell.Key % Columns;
                tempList.Add((row, column, cell.Value));
            }
            var orderedList = tempList.OrderBy(t => t.Item2).ThenBy(t => t.Item1);
            return orderedList;
        }

        public IEnumerator<int> GetEnumerator()
        {
            //return MatrixElements.Values.GetEnumerator();
            //return new SparseMatrixEnumerator(Size , MatrixElements) as IEnumerator<int>;
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //return MatrixElements.GetEnumerator();

        }

    }
}
