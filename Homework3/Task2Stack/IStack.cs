using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Stack
{
    public interface IStack<T>
    {
        bool IsEmpty();
        void Push(T item);
        T Peek();
        T Pop();
        //Stack<T> Reverse(); Why does it work here, but in extension method Reverse() needs a <T> type?
    }
}