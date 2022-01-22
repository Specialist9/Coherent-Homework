using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Stack
{
    static class ReverseExtension
    {
        public static Stack<T> Reverse<T>(this IStack<T> stack)
        {
            return new Stack<T>(1);
        }

    }
}
