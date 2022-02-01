using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1SparseMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            SparseMatrix SpMatrix1 = new(3, 3);
            SpMatrix1[0, 0] = 27;
            Console.WriteLine(SpMatrix1[2, 2]);
            Console.WriteLine(SpMatrix1[1, 1]);
            Console.WriteLine();
            Console.WriteLine(SpMatrix1.ToString());
            SpMatrix1[0, 1] = 45;
            Console.WriteLine(SpMatrix1.ToString());

            /*foreach(var cell in SpMatrix1)
            {
                Console.WriteLine(cell);
            }*/
            Console.WriteLine(SpMatrix1.GetCount(0));
            
        }
    }
}
