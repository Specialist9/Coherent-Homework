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
            var reversedStack = new Stack<T>(16);

            while (!stack.IsEmpty())
            {
                reversedStack.Push(stack.Pop());
            }

            return reversedStack;
        }

    }
}
