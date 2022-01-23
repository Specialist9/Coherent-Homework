using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1GenericDiagonalMatrix
{
    public class ElementChangedEventArgs<T> : EventArgs
    {
        public T OldValue;
        public T NewValue;
        public int ElementIndex;

        public ElementChangedEventArgs(T oldValue, T newValue, int elementIndex)
        {
            OldValue = oldValue;
            NewValue = newValue;
            ElementIndex = elementIndex;
        }
    }
}
