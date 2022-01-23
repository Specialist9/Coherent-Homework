using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1GenericDiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Matrix<string> Matrix1 = new(2);
                Matrix1.ElementChanged += matrix_ElementChanged;
                Matrix1[1, 1] = "abc";
                Matrix1[1, 1] = "def";
                Matrix1[1, 1] = "def";
                Matrix1[0, 0] = "xyz";
                Matrix1[0, 1] = "mno";

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Matrix size can't be negative");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid matrix index");
            }

            void matrix_ElementChanged(object sender, ElementChangedEventArgs<string> e)
            {
                Console.WriteLine($"Matrix element [{e.ElementIndex}, {e.ElementIndex}] changed from {e.OldValue} to {e.NewValue}");
            }
            
        }
    }
}
