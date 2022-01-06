namespace Task2Stack
{
    public interface IStack<T>
    {
        bool isEmpty();
        void Push(T item);
        T Peek();
        T Pop();
        //T[] Reverse();
    }
}