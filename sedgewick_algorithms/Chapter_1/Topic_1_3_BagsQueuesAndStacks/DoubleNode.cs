namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class DoubleNode<T>
    {
        public DoubleNode<T> Next;
        public DoubleNode<T> Prev;
        
        public T Value { get; }

        public DoubleNode(T value)
        {
            Value = value;
        }
    }
}