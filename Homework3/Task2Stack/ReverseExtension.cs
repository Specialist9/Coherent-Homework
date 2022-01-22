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
        public static Stack<T> Reverse<T>(this IStack<T> stack) // Why does the method name need to include <T> here, but not in IStack
        {
            return new Stack<T>(default);
        }

    }
}
