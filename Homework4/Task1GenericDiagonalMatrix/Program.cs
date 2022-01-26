using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1GenericDiagonalMatrix
{
    class Program
    {
        //public delegate T Add2GenTypes<T>(T type1, T type2);
        static float AddIntTypes(float a, float b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            try
            {
                DiagonalMatrix<float> Matrix1 = new(2);
                Matrix1.ElementChanged += Matrix1.matrix_ElementChanged;
                Matrix1[0, 0] = 3;
                Matrix1[0, 0] = 3;

                Matrix1[0, 0] = 4;
                Matrix1[1, 1] = 9;


                DiagonalMatrix<float> Matrix2 = new(2);
                Matrix2.ElementChanged += Matrix1.matrix_ElementChanged;

                Matrix2[0, 0] = 10;
                Matrix2[1, 1] = 20;

                MatrixTracker<int> MTracker1 = new(Matrix2);

                Matrix2[1, 1] = 30;
                MTracker1.Undo();


                //Add2GenTypes<int> del1 = new Add2GenTypes<int>(AddGenericTypes);

                Matrix1.MatrixAdd(Matrix2, AddIntTypes);

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Matrix size can't be negative");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid matrix index");
            }




        }
    }
}
