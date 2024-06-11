namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public interface IDeque<T>
    {
        bool IsEmpty { get; }
        int Count { get; }
        void PushLeft(T item);
        void PushRight(T item);
        T PopLeft();
        T PopRight();
    }
}