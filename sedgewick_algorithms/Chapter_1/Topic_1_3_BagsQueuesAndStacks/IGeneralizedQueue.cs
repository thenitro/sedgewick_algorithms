namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public interface IGeneralizedQueue<T>
    {
        bool IsEmpty();
        void Insert(T item);
        T Delete(int index);
    }
}