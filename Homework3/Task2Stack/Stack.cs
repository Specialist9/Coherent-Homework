using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Stack
{
    public class Stack<T> : IStack<T>
    {
        private readonly T[] myStack;
        private int top;
        private readonly int stackSize;

        public Stack(int size)
        {
            stackSize = size > 0 ? size : 1;
            top = -1;
            myStack = new T[size];
        }

        public Stack(int size, params T[] stackValues)
        {
            stackSize = size > 0 ? size : 1;
            top = -1;
            myStack = stackValues;
        }

        public bool IsEmpty()
        {
            return top < 0 ;
        }

        public T Peek()
        {
            if(top < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T value = myStack[top];
                return value;
            }
        }

        public T Pop()
        {
            if(top < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                T value = myStack[top--];
                return value;
            }

        }

        public void Push(T item)
        {
            if(top >= (stackSize-1))
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                myStack[++top] = item;
            }
            
        }

        public override string ToString()
        {
            StringBuilder tempString = new();

            for (int i = top; i >= 0; i--)
            {
                tempString.Append($"{myStack[i]}, ");

            }
            
            return tempString.ToString();
        }


        public Stack<T> Reverse()
        {
            T[] reversedStack = myStack;
            Array.Reverse(reversedStack);
            return new Stack<T>(stackSize, reversedStack);
        }

    }
}
