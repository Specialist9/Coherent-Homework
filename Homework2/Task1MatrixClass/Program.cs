using System;
using System.Text;


namespace Task1MatrixClass
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] testNumbers = { 9, 6, 4, };
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
            Console.WriteLine("\n" + TestMatrix2.Track() + "\n\n");

            Console.WriteLine(TestMatrix.Equals(TestMatrix1));
            Console.WriteLine(TestMatrix.Equals(TestMatrix2));

            Console.WriteLine(TestMatrix1.ToString());
            Console.WriteLine();

            Console.WriteLine((TestMatrix.MatrixAdd(TestMatrix2)).ToString());
            
        }

    }

}