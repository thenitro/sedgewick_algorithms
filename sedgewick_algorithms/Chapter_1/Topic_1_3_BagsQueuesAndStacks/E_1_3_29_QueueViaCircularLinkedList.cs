namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_29_QueueViaCircularLinkedList<T>
    {
        public int Count { get; private set; }
        
        private CircularLinkedList<T> _data = new CircularLinkedList<T>();

        public void Enqueue(T value)
        {
            _data.Add(new LinkedListNode<T>(value));
            Count++;
        }

        public T Dequeue()
        {
            if (_data.First == null) return default;
            
            var first = _data.PopFirst();
            Count--;
            return first;
        }
    }
}