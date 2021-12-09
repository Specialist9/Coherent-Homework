using System;

namespace Task1MatrixClass
{
    class Program
    {

		public class Matrix
		{
			readonly int Size = 3;

			public Matrix(params int[] numbersdiagonal)
			{

				int[,] array2D = new int[Size, Size];

				var value = 0;
				for (int i = 0; i < Size; i++)
				{
					for (int j = 0; j < Size; j++)
					{
						value = numbersdiagonal[i];
						if (i == j)
						{
							array2D[i, j] = value;
						}
						else
						{
							array2D[i, j] = 0;
						}

					}
				}

				Console.WriteLine(array2D);
			}
		}
		static void Main(string[] args)
        {
			int[] testNumbers = { 7, 8, 2 };
			Matrix MatrixTest = new Matrix(testNumbers);
			Console.WriteLine(testNumbers);
		}
    }
}
