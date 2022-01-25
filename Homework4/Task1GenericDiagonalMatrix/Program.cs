using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1GenericDiagonalMatrix
{
    class Program
    {
        delegate T Add2GenTypes<T>(T type1, T type2);

        static T AddGenericTypes<T>(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }
        static void Main(string[] args)
        {

            try
            {
                Matrix<int> Matrix1 = new(2);
                Matrix1.ElementChanged += matrix_ElementChanged;
                Matrix1[1, 1] = 1;
                Matrix1[1, 1] = 2;
                Matrix1[1, 1] = 3;
                Matrix1[0, 0] = 9;
                Matrix1[0, 1] = 8;

                Matrix<int> Matrix2 = new(2);
                Matrix2[0, 0] = 10;
                Matrix2[1, 1] = 20;

                var delegate1 = new Add2GenTypes<int>(AddGenericTypes); 

                Matrix1.

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Matrix size can't be negative");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid matrix index");
            }

            void matrix_ElementChanged(object sender, ElementChangedEventArgs<int> e)
            {
                Console.WriteLine($"Matrix element [{e.ElementIndex}, {e.ElementIndex}] changed from {e.OldValue} to {e.NewValue}");
            }



        }
    }
}
