﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1SparseMatrix
{
    class SparseMatrix: IEnumerable
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
                MatrixElements.TryGetValue(index, out result);
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
            /*
            foreach(var matrixcell in MatrixElements)
            {
                tempString.Append($"{matrixcell} / ");
            }*/
            for(int i = 0; i < Size; i++)
            {
                int cellValue = MatrixElements.TryGetValue(i, out cellValue) ? cellValue : default;
                tempString.Append($" {cellValue},");

            }
            
            return tempString.ToString();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new SparseMatrixEnumerator(Size , MatrixElements) as IEnumerator<int>;

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
 
        }

        public int GetCount(int x)
        {
            int count = 0;

            for (int i = 0; i < Size; i++)
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
    }
}
