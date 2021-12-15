using System;
using System.Text;

namespace Task1MatrixClass
{
    class Program
    {
        public class Matrix
        {
            readonly int Size;
            readonly int[] diagonalArray;

            public Matrix(int matrixSize, params int[] diagonalNumbers)
            {
                Size = matrixSize;
                diagonalArray = diagonalNumbers;

                if ((matrixSize != diagonalNumbers.Length) || (diagonalNumbers == null))
                {
                   Size = 0;
                }
                Console.WriteLine(Size);
            }
            public int this[int i, int j]
            {
                get
                {
                    if ((i == j) && (i >= 0) && (i < diagonalArray.Length))
                    {
                        return diagonalArray[i];
                    }
                    else if(i < 0 || i >= diagonalArray.Length)
                    {
                        return 0;
                    }
                    
                    else
                    {
                        return 0;
                    }
                }
                                
            }

            public int Track()
            {
                int diagonalSum = 0;

                for (int i = 0, j = 0; i < diagonalArray.Length; i++, j++)
                {
                    if(i == j)
                    {
                        diagonalSum += diagonalArray[i];
                    }
                    
                }
                return diagonalSum;
            }

            public string PrintMatrixElements()
            {
                var builder = new StringBuilder();

                foreach (int number in diagonalArray)
                {
                    builder.Append(number.ToString());
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
                                    
                for(int i = 0; i < diagonalArray.Length; i++)
                {
                    if(diagonalArray[i] != testItem.diagonalArray[i])
                    {
                        return false;
                    }
                }
                
                return true;
            }

                
            public override int GetHashCode()
            {
                return  base.GetHashCode();
            }

            public override string ToString()
            {
                return "Matrix-Size is " + Size + " Elements are " + PrintMatrixElements();
            }
        }


		static void Main(string[] args)
        {

            int[] testNumbers = { 9, 6, 4 };
            int testSize = 3;

            int[] testNumbers2 = { 7, 5, 8 };
            int testSize2 = 3;

            Matrix TestMatrix = new Matrix(testSize, testNumbers);
            Matrix TestMatrix1 = new Matrix(testSize, testNumbers);
            Matrix TestMatrix2 = new Matrix(testSize2, testNumbers2);

            Console.WriteLine(TestMatrix[0, 0]);
            Console.WriteLine(TestMatrix[1, 1]);
            Console.WriteLine(TestMatrix[3, 3]);
            Console.WriteLine(TestMatrix[2, 2]);
            Console.WriteLine(TestMatrix.Track()+"\n\n");

            Console.WriteLine(TestMatrix.Equals(TestMatrix1));
            Console.WriteLine(TestMatrix.Equals(TestMatrix2));

            Console.WriteLine(TestMatrix1.ToString());
            


        }
    }
}
