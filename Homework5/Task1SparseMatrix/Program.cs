using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1SparseMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            SparseMatrix SpMatrix1 = new(2, 3);
            SpMatrix1[0, 0] = 27;
            int zero = SpMatrix1[0, 0];
            Console.WriteLine(zero);
            Console.WriteLine("***********");

            Console.WriteLine(SpMatrix1.ToString());
            SpMatrix1[0, 1] = 45;
            SpMatrix1[1, 1] = 32;

            Console.WriteLine(SpMatrix1.ToString());

            Console.WriteLine("///////////////////");

            foreach (var cell in SpMatrix1)
            {
                Console.WriteLine(cell);
            }
            Console.WriteLine("////////////////////");

            Console.WriteLine(SpMatrix1.GetCount(27));

        }
    }
}
