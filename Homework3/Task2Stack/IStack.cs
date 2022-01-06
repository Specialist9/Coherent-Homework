namespace Task2Stack
{
    public interface IStack<T>
    {
        int Count { get; }
        bool IsEmpty { get; }

        T Peek();
        T Pop();
        void Push(T item);
    }
}