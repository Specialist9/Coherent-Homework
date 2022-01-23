using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1GenericDiagonalMatrix
{
    class Matrix<T>
    {
        int Size { get; }
        T[] DiagonalArray { get; }

        public Matrix(int size)
        {
            Size = size >= 0 ? size : throw new ArgumentException();
            DiagonalArray = new T[size];
        }

        public T this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= DiagonalArray.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else if (i == j)
                {
                    return DiagonalArray[i];
                }
                else return default;
            }

            set
            {
                if (i < 0 || i >= DiagonalArray.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                else if (i == j)
                {
                    if (DiagonalArray[i] != null && DiagonalArray[i].Equals(value)) return;
                    T oldValue = DiagonalArray[i];
                    DiagonalArray[i] = value;
                    OnElementChanged(new ElementChangedEventArgs<T>(oldValue, value, i));

                }
                
            }
        }

        public event EventHandler<ElementChangedEventArgs<T>> ElementChanged;

        protected virtual void OnElementChanged(ElementChangedEventArgs<T> e)
        {
            ElementChanged?.Invoke(this, e);
        }


    }
}
