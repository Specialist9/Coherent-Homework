using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Stack
{
    static class ReverseExtension
    {
        public static Stack<T> Reverse<T>(this IStack<T> stack, Stack<T> originalStack)
        {
            Array.Reverse(originalStack.MyStack());
            Console.WriteLine("This is the reverse ext method");
            return originalStack;
        }

    }
}
