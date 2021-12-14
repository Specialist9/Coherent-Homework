using System;

namespace Task1MatrixClass
{
    class Program
    {
        public class Matrix
        {
            readonly int Size = 3;
            int[] diagonalArray;

            public Matrix(int matrixsize, params int[] diagonalNumbers)
            {
                Size = matrixsize;
                diagonalArray = diagonalNumbers;

            }
            public int this[int i, int j]
            {
                get
                {
                    if (i == j)
                    {
                        return diagonalArray[i];
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

            int[] testNumbers = { 9, 6, 3 };

            Matrix TestMatrix = new Matrix(3, testNumbers);
            Console.WriteLine(TestMatrix[0, 0]);
            Console.WriteLine(TestMatrix[1, 1]);
            Console.WriteLine(TestMatrix[2, 2]);
            Console.WriteLine(TestMatrix[0, 1]);
        }
    }
}
