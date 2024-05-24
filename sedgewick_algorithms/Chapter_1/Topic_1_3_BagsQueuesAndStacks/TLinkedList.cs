namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class TLinkedList<T>
    {
        public Node<T> First { get; set; }

        public TLinkedList(Node<T> first)
        {
            First = first;
        }
    }

    public class Node<T>
    {
        public T Value { get; }
        public Node<T> Next;

        public Node(T value, Node<T> next)
        {
            Value = value;
            Next = next;
        }

        public Node(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"[Node value={Value}]";
        }
    }
}