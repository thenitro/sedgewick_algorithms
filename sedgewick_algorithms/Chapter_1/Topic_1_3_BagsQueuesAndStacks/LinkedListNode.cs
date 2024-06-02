namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class LinkedListNode<T>
    {
        public T Value { get; }
        public LinkedListNode<T> Next;

        public bool HasNext => Next != null;

        public LinkedListNode(T value, LinkedListNode<T> next)
        {
            Value = value;
            Next = next;
        }

        public LinkedListNode(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"[Node value={Value}]";
        }
    }
}