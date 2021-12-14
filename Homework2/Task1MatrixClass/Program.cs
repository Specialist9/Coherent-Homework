using System;

namespace Task1MatrixClass
{
    class Program
    {
        public class Matrix
        {
            readonly int Size;
            int[] diagonalArray;

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
        }


		static void Main(string[] args)
        {

            int[] testNumbers = { 9, 6, 4 };
            int testSize = 5;

            Matrix TestMatrix = new Matrix(testSize, testNumbers);

            Console.WriteLine(TestMatrix[0, 0]);
            Console.WriteLine(TestMatrix[1, 1]);
            Console.WriteLine(TestMatrix[3, 3]);
            Console.WriteLine(TestMatrix[2, 2]);
            
        }
    }
}
