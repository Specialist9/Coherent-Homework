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
            SpMatrix1[2, 2] = 27;
            Console.WriteLine(SpMatrix1[2, 2]);
        }
    }
}
