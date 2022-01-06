using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Stack
{
    public class Stack<T> : IStack<T>
    {
        private T[] myStack;
        private int top;
        private int stackSize;

        public T[] MyStack()
        {
            return myStack;
        }

        public Stack(int size)
        {
            stackSize = size;
            top = -1;
            myStack = new T[size];
        }

        public bool isEmpty()
        {
            return (top < 0) ;
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

    }
}
